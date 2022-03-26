using Domain.Base;

namespace Domain.Entities
{
    public class City : BaseEntity<Guid>
    {
        protected City()
        {

        }

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

        public string Name { get; set; }

        public ICollection<CityAccommodation> CityAccommodations { get; set; }

        public virtual ICollection<School> Schools { get; set; }

        public IEnumerable<Accommodation> Accommodations { get => CityAccommodations.Select(ca => ca.Accommodation); }
    }
}
