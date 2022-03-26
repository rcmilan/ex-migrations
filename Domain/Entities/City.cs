using Domain.Base;

namespace Domain.Entities
{
    public class City : BaseEntity<Guid>
    {
        public string Name { get; set; }

        public IEnumerable<CityAccommodation> CityAccommodations { get; set; }

        public virtual IEnumerable<Accommodation> Accommodations { get => CityAccommodations.Select(ca => ca.Accommodation); }
    }
}
