using Domain.Base;

namespace Domain.Entities
{
    public class School : BaseEntity<long>
    {
        public string Name { get; set; }

        public virtual City City { get; set; }

        public DateTime Foundation { get; private set; }
    }
}
