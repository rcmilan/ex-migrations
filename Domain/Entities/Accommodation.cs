using Domain.Base;

namespace Domain.Entities
{
    public class Accommodation : BaseEntity<long>
    {
        public string Name { get; set; }
        public int Rooms { get; set; }
        public Address Address { get; set; }
    }
}
