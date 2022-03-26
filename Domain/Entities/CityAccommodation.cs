using Domain.Base;

namespace Domain.Entities
{
    public class CityAccommodation : BaseEntity<int>
    {
        protected CityAccommodation()
        {

        }

        public CityAccommodation(City city, Accommodation accommodation)
        {
            City = city;
            Accommodation = accommodation;
        }

        public virtual City City { get; set; }
        public virtual Accommodation Accommodation { get; set; }
    }
}
