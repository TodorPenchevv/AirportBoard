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
                Airline airline = new Airline();
                airline.setName(name);
                airline.setCountryId(countryId);
                airline.save();
        }

        public override void update()
        {
            Airline airline = new Airline();
            airline.setId(id);
            airline.setName(name);
            airline.setCountryId(countryId);
            airline.update();
        }

        public override void delete()
        {
            Airline airline = new Airline();
            airline.setId(id);
            airline.delete();
        }
    }
}
