using System;

namespace TransactionManagement.Core.Entities.PersonAggregate
{
    public class TypeOfPayee : BaseEntity<int>
    {
        public TypeOfPayee(int id, string type, string description) : base(id)
        {
            Type = !string.IsNullOrWhiteSpace(type) ? type : throw new ArgumentNullException("Debe de digitar una categoria");
            Description = !string.IsNullOrWhiteSpace(description) ? description : throw new ArgumentNullException("Debe de digitar una description");
        }

        public string Type { get; private set; }

        public string Description { get; private set; }
    }
}
