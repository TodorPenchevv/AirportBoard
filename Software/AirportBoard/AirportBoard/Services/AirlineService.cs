using AirportBoard.Exceptions;
using AirportBoard.Logging;
using AirportBoard.Models;

namespace AirportBoard.Services
{
    internal class AirlineService : Service
    {
        private string id;
        private string name;
        private string countryId;

        public AirlineService() {}

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
                Airline airline = new Airline();
                airline.setName(name);
                airline.setCountryId(countryId);
                airline.save();
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
                Airline airline = new Airline();
                airline.setId(id);
                airline.setName(name);
                airline.setCountryId(countryId);
                airline.update();
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
                Airline airline = new Airline();
                airline.setId(id);
                airline.delete();
            }
            catch (Exception e)
            {
                Notification.show("Error", e.Message);
            }
        }
    }
}
