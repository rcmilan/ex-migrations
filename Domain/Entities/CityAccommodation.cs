using Domain.Base;

namespace Domain.Entities
{
    public class CityAccommodation : BaseEntity<int>
    {
        public virtual City City { get; set; }
        public virtual Accommodation Accommodation { get; set; }
    }
}
