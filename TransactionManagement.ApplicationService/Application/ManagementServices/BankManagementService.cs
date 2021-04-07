using System;
using System.Collections.Generic;
using TransactionManagement.ApplicationService.Adapters.DTOs;
using TransactionManagement.ApplicationService.Adapters.Mappers;
using TransactionManagement.Core.Entities.BankAggregate;
using TransactionManagement.Core.Exceptions.BankExceptions;
using TransactionManagement.Core.Interfaces.Repositories;
using TransactionManagement.Core.Interfaces.Services;
using TransactionManagement.Core.Queries;

namespace TransactionManagement.ApplicationService.Application.ManagementServices
{
    public class BankManagementService : IBankManagementService
    {
        private readonly IBankRepository _bankRespository;
        private readonly IBankService _bankService;
        private readonly BankMap _map;

        public BankManagementService(IBankRepository bankRespository, IBankService bankService)
        {
            _bankRespository = bankRespository;
            _bankService = bankService;
            _map = new BankMap();
        }

        public int CreateBank(BankDto bankDto)
        {
            if (bankDto == null)
            {
                throw new ArgumentNullException(nameof(bankDto));
            }

            BankEntity entity = _map.FromBankDtoToBankEntity(bankDto);

            return _bankRespository.Create(entity, BankScripts.CreateBankEntity);
        }

        public void RemoveBank(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException(nameof(id));
            }

            BankEntity bankEntity = _bankRespository.GetEntityById(id, BankScripts.GetBankById);
            if (bankEntity == null)
            {
                throw new NoFoundBankException(bankEntity.BankName, new KeyNotFoundException());
            }

            _bankRespository.Remove(id, BankScripts.RemoveBankEntity);
        }

        public void UpdateBank(BankDto bankDto)
        {
            if (bankDto == null)
            {
                throw new ArgumentNullException(nameof(bankDto));
            }

            BankEntity entity = _bankRespository.GetEntityById(bankDto.Id, BankScripts.GetBankById);
            if (entity == null)
            {
                throw new NoFoundBankException(entity.BankName, new KeyNotFoundException());
            }

            entity.UpdateBank(bankDto.BankName, bankDto.Phone, bankDto.City, bankDto.Address);
            _bankRespository.Update(entity, BankScripts.UpdateBankEntitye);
        }

        public BankDto GetBankDtoById(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException(nameof(id));
            }

            BankEntity entity = _bankRespository.GetEntityById(id, BankScripts.GetBankById);
            if (entity == null)
            {
                throw new NoFoundBankException(entity.BankName, new KeyNotFoundException());
            }

            return _map.FromBankEntityToBankDto(entity);
        }

        public BankDto GetBankWithAccountsDtosById(int bankId)
        {
            BankEntity bankEntity = _bankRespository.GetEntityById(bankId, BankScripts.GetBankById);
            IEnumerable<BankAccountEntity> bankAccounts =
                _bankRespository.GetBankAccountsEntitiesByBankId(bankId, BankScripts.GetBankAccountsEntitiesByBankId);

            if (bankAccounts != null)
            {
                _bankService.SetBankAccount(bankEntity, bankAccounts);
            }

            return _map.FromBanEntitykWithAccountEntitiesToBankDtoWithAccountDtos(bankEntity);
        }

        public IEnumerable<BankDto> GetBankDtos()
        {
            IEnumerable<BankEntity> bankEntity = _bankRespository.GetEntities(BankScripts.GetBankEntities);

            return _map.FromBankEntitiesToBankDtos(bankEntity);
        }

        public IEnumerable<BankDto> GetBankWithAccountsDtos()
        {
            IEnumerable<BankEntity> bankEntities = _bankRespository.GetEntities(BankScripts.GetBankEntities);
            IEnumerable<BankAccountEntity> bankAccounts = _bankRespository.GetBankAccountEntities(BankScripts.GetBankAccountsEntities);

            if (bankAccounts != null)
            {
                _bankService.SetBankAccount(bankEntities, bankAccounts);
            }

            return _map.FromBankWithAccountEntitiesToBankWithAccountDtos(bankEntities);
        }

        public int CreateBankAccount(BankAccountDto bankAccountDto)
        {
            if (bankAccountDto == null)
            {
                throw new ArgumentException(nameof(bankAccountDto));
            }

            BankAccountEntity bankAccountEntity = _map.FromBankAccountDtoToBankAccountEntity(bankAccountDto);

            return _bankRespository.CreateBankAccount(bankAccountEntity, BankScripts.CreateBankAccountEntity);
        }

        public void RemoveBankAccount(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var bankAccount = _bankRespository.GetBankAccountEntityById(id, BankScripts.GetBankAccountById);
            if (bankAccount == null)
            {
                throw new NotFoundBankAccountException(nameof(bankAccount), new KeyNotFoundException());
            }

            _bankRespository.RemoveBankAccount(id, BankScripts.RemoveBankAccountEntity);
        }

        public void UpdateBankAccount(BankAccountDto bankAccountDto)
        {
            if (bankAccountDto == null)
            {
                throw new ArgumentNullException(nameof(bankAccountDto));
            }

            var bankAccountEntity = _bankRespository.GetBankAccountEntityById(bankAccountDto.Id, BankScripts.GetBankAccountById);
            if (bankAccountEntity == null)
            {
                throw new NotFoundBankAccountException(nameof(bankAccountDto), new KeyNotFoundException());
            }

            bankAccountEntity.UpdateAccount(bankAccountDto.AccountNumber, bankAccountDto.Balance, bankAccountDto.BalanceInTransit, bankAccountDto.BalanceAvailable, bankAccountDto.IsItLocked, bankAccountDto.AccountType, bankAccountDto.Incumbent,bankAccountDto.BankId);
            _bankRespository.UpdateBankAccount(bankAccountEntity, BankScripts.UpdateBankAccountEntity);
        }

        public IEnumerable<BankAccountDto> GetBankAccountDtos()
        {
            return null;
        }

        public IEnumerable<BankAccountDto> GetBankAccountDtoByIdOrBankId(int id)
        {
            return null;
        }
    }
}
