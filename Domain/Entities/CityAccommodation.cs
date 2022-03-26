using Domain.Base;

namespace Domain.Entities
{
    public class CityAccommodation : BaseEntity<int>
    {
        public City City { get; set; }
        public Accommodation Accommodation { get; set; }
    }
}
