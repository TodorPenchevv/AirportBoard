using AirportBoard.Exceptions;
using AirportBoard.Logging;
using AirportBoard.Models;

namespace AirportBoard.Services
{
    internal class CityService : Service
    {
        private string id;
        private string name;
        private string countryId;

        public CityService() {}

        public override void setFields(Dictionary<string, string> values)
        {
            id = valueContains(values, "id");
            name = valueContains(values, "name");
            countryId = valueContains(values, "countryId");
        }

        public override void save()
        {
            City city = new City();
            city.setName(name);
            city.setCountryId(countryId);
            city.save();
        }

        public override void update()
        {
            City city = new City();
            city.setId(id);
            city.setName(name);
            city.setCountryId(countryId);
            city.update();
        }

        public override void delete()
        {
            City city = new City();
            city.setId(id);
            city.delete();
        }
    }
}
