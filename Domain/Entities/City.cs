using Domain.Base;

namespace Domain.Entities
{
    public class City : BaseEntity<Guid>
    {
        public City(string name)
        {
            Name = name;
        }

        public City AddAccommodation(Accommodation accommodation)
        {
            if (CityAccommodations == null)
                CityAccommodations = new List<CityAccommodation>();

            CityAccommodations.Add(new CityAccommodation(this, accommodation));

            return this;
        }

        public string Name { get; private set; }

        public DateOnly Foundation { get; private set; }

        public ICollection<CityAccommodation> CityAccommodations { get; private set; }

        public virtual ICollection<School> Schools { get; private set; }

        public IEnumerable<Accommodation> Accommodations { get => CityAccommodations.Select(ca => ca.Accommodation); }
    }
}
