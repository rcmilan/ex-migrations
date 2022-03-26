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
            var cityAccommodations = new List<CityAccommodation>();

            cityAccommodations.ToList().Add(new CityAccommodation(this, accommodation));

            CityAccommodations.Concat(cityAccommodations);

            return this;
        }

        public string Name { get; set; }

        public IEnumerable<CityAccommodation> CityAccommodations { get; set; } = Enumerable.Empty<CityAccommodation>();

        public virtual IEnumerable<Accommodation> Accommodations { get => CityAccommodations.Select(ca => ca.Accommodation); }
    }
}
