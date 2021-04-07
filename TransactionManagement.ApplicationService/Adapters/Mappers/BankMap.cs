using System.Collections.Generic;
using TransactionManagement.ApplicationService.Adapters.DTOs;
using TransactionManagement.Core.Entities.BankAggregate;

namespace TransactionManagement.ApplicationService.Adapters.Mappers
{
    internal class BankMap
    {
        internal BankEntity FromBankDtoToBankEntity(BankDto bankDto)
        {
            return new BankEntity(bankDto.Id, bankDto.BankName, bankDto.Phone, bankDto.City, bankDto.Address);
        }

        internal BankDto FromBankEntityToBankDto(BankEntity bankEntiy)
        {
            return new BankDto
            {
                Id = bankEntiy.Id,
                BankName = bankEntiy.BankName,
                Phone = bankEntiy.Phone,
                City = bankEntiy.City,
                Address = bankEntiy.Address
            };
        }

        internal IEnumerable<BankDto> FromBankEntitiesToBankDtos(IEnumerable<BankEntity> bankEntities)
        {
            List<BankDto> bankDtos = new List<BankDto>();

            foreach (BankEntity entity in bankEntities)
            {
                bankDtos.Add(new BankDto
                {
                    Id = entity.Id,
                    BankName = entity.BankName,
                    Phone = entity.Phone,
                    City = entity.City,
                    Address = entity.Address
                });
            }

            return bankDtos;
        }

        internal IEnumerable<BankDto> FromBankWithAccountEntitiesToBankWithAccountDtos(IEnumerable<BankEntity> bankEntities)
        {
            List<BankDto> bankDtos = new List<BankDto>();

            foreach (BankEntity bankEntity in bankEntities)
            {
                BankDto bankDto = new BankDto
                {
                    Id = bankEntity.Id,
                    BankName = bankEntity.BankName,
                    Phone = bankEntity.Phone,
                    City = bankEntity.City,
                    Address = bankEntity.Address,
                };

                foreach (BankAccountEntity bankAccountEntity in bankEntity.GetAccounts)
                {
                    BankAccountDto accountDto = new BankAccountDto
                    {
                        Id = bankAccountEntity.Id,
                        AccountNumber = bankAccountEntity.AccountNumber,
                        Balance = bankAccountEntity.Balance,
                        BalanceInTransit = bankAccountEntity.BalanceInTransit,
                        BalanceAvailable = bankAccountEntity.BalanceAvailable,
                        IsItLocked = bankAccountEntity.IsItLocked,
                        AccountType = bankAccountEntity.AccountType,
                        Incumbent = bankAccountEntity.Incumbent,
                        BankId = bankAccountEntity.BankId
                    };

                    bankDto.BankAccountDTOs.Add(accountDto);
                }

                bankDtos.Add(bankDto);
            }

            return bankDtos;
        }

        internal IEnumerable<BankAccountDto> FromBankAccountEntitiesToBankAccountDTOs(IEnumerable<BankAccountEntity> bankAccounts)
        {
            List<BankAccountDto> bankAccountDtos = new List<BankAccountDto>();

            foreach (BankAccountEntity bankAccount in bankAccounts)
            {
                BankAccountDto bankAccountDto = new BankAccountDto
                {
                    Id = bankAccount.Id,
                    AccountNumber = bankAccount.AccountNumber,
                    Balance = bankAccount.Balance,
                    BalanceInTransit = bankAccount.BalanceInTransit,
                    BalanceAvailable = bankAccount.BalanceAvailable,
                    IsItLocked = bankAccount.IsItLocked,
                    AccountType = bankAccount.AccountType,
                    Incumbent = bankAccount.Incumbent,
                    BankId = bankAccount.BankId
                };

                bankAccountDtos.Add(bankAccountDto);
            }

            return bankAccountDtos;
        }

        internal BankDto FromBanEntitykWithAccountEntitiesToBankDtoWithAccountDtos(BankEntity bankEntity)
        {
            BankDto bankDto = new BankDto
            {
                Id = bankEntity.Id,
                BankName = bankEntity.BankName,
                Phone = bankEntity.Phone,
                City = bankEntity.City,
                Address = bankEntity.Address,
            };

            foreach (BankAccountEntity bankAccountEntity in bankEntity.GetAccounts)
            {
                BankAccountDto accountDto = new BankAccountDto
                {
                    Id = bankAccountEntity.Id,
                    AccountNumber = bankAccountEntity.AccountNumber,
                    Balance = bankAccountEntity.Balance,
                    BalanceInTransit = bankAccountEntity.BalanceInTransit,
                    BalanceAvailable = bankAccountEntity.BalanceAvailable,
                    IsItLocked = bankAccountEntity.IsItLocked,
                    AccountType = bankAccountEntity.AccountType,
                    Incumbent = bankAccountEntity.Incumbent,
                    BankId = bankAccountEntity.BankId
                };

                bankDto.BankAccountDTOs.Add(accountDto);
            }

            return bankDto;
        }

        internal BankAccountEntity FromBankAccountDtoToBankAccountEntity(BankAccountDto bankAccountDto)
        {
            return new BankAccountEntity(bankAccountDto.Id, bankAccountDto.AccountNumber, bankAccountDto.Balance, bankAccountDto.BalanceInTransit,
                bankAccountDto.BalanceAvailable,  bankAccountDto.AccountType, bankAccountDto.BankId, bankAccountDto.Incumbent, bankAccountDto.IsItLocked);
        }
    }
}