using Domain.Base;

namespace Domain.Entities
{
    public class School : BaseEntity<long>
    {
        public string Name { get; set; }

        public City City { get; set; }
    }
}
