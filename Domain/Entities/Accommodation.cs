using Domain.Base;

namespace Domain.Entities
{
    public class Accommodation : BaseEntity<long>
    {
        protected Accommodation()
        {

        }

        public Accommodation(string name, int rooms)
        {
            Name = name;
            Rooms = rooms;
        }
        public string Name { get; set; }
        public int Rooms { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
    }
}
