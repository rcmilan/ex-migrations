using Domain.Base;

namespace Domain.Entities
{
    public class Address : BaseEntity<int>
    {
        public string Street { get; set; }
        public string District { get; set; }
        public string ZipCode { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
    }
}
