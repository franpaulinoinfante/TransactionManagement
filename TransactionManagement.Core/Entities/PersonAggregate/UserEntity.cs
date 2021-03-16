using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionManagement.Core.Entities.BankAggregate;

namespace TransactionManagement.Core.Entities.PersonAggregate
{
    public class UserEntity : PersonEntity
    {
        private List<Transaction> _transactions = new List<Transaction>();

        public UserEntity(int id) : base(id)
        {

        }

        public UserEntity(int id, string firstName, string lastName, string gender, string phone,
            string city, string address, int? documentTypeId, string documentCode, string userName, string password)
         : base(id, firstName, lastName, gender, phone, city, address, documentTypeId, documentCode)
        {
            UserName = userName;
            Password = password;
        }


        public string UserName { get; private set; }

        public string Password { get; private set; }

        public Byte[] Picture { get; private set; }

        public IReadOnlyCollection<Transaction> Transactions => _transactions.AsReadOnly();

        public void UpdateUser(string userName, string passWord)
        {
            if ((string.IsNullOrWhiteSpace(userName)) || (string.IsNullOrWhiteSpace(passWord)))
            {
                throw new System.Exception($@"El tipo de documento - { nameof(userName) } o\n 
                        la descripción - { nameof(passWord) } es un espacio en blanco!");
            }

            UserName = userName;
            Password = passWord;
        }

        public void AddPicture(Byte[] picture)
        {
            Picture = picture ?? throw new NullReferenceException($"Debe seleccionar una imagen, { nameof(picture) }");
        }
    }
}
