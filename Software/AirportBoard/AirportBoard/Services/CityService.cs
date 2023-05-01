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
            try
            {
                City city = new City();
                city.setName(name);
                city.setCountryId(countryId);
                city.save();
            }
            catch (Exception e)
            {
                Notification.show("Error", e.Message);
            }
        }

        public override void update()
        {
            try
            {
                City city = new City();
                city.setId(id);
                city.setName(name);
                city.setCountryId(countryId);
                city.update();
            }
            catch (Exception e)
            {
                Notification.show("Error", e.Message);
            }
        }

        public override void delete()
        {
            try
            {
                City city = new City();
                city.setId(id);
                city.delete();
            }
            catch (Exception e)
            {
                Notification.show("Error", e.Message);
            }
        }
    }
}
