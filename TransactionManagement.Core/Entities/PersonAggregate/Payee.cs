namespace TransactionManagement.Core.Entities.PersonAggregate
{
    public class Payee : Person
    {
        public Payee(int id, string firstName, string lastName, char gender, int typeOfPayeeId) : base(id, firstName, lastName, gender)
        {
            TypeOfPayeeId = typeOfPayeeId;
        }

        public int TypeOfPayeeId { get; set; }
        public TypeOfPayee TypeOfPayee { get; set; }

        public void SetTypeOfPayee(TypeOfPayee typeOfPayee)
        {
            TypeOfPayee = typeOfPayee ?? throw new System.NullReferenceException(nameof(typeOfPayee));


            //TypeOfPayee =  typeOfPayee != null ? typeOfPayee : throw new System.NullReferenceException(nameof(typeOfPayee));

            //if (TypeOfPayeeId == typeOfPayee.Id)
            //{
            //    TypeOfPayee = typeOfPayee;
            //}
        }


    }
}
