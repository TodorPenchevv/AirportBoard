using AirportBoard.Logging;
using AirportBoard.Models;

namespace AirportBoard.Services
{
    internal class DestinationService : Service
    {
        private string id;
        private string airport;
        private string cityId;

        public DestinationService() {}

        public override void setFields(Dictionary<string, string> values)
        {
            id = valueContains(values, "id");
            airport = valueContains(values, "airport");
            cityId = valueContains(values, "cityId");
        }

        public override void save()
        {
            Destination destination = new Destination();
            destination.setAirport(airport);
            destination.setCityId(cityId);
            destination.save();
        }

        public override void update()
        {
            Destination destination = new Destination();
            destination.setId(id);
            destination.setAirport(airport);
            destination.setCityId(cityId);
            destination.update();
        }

        public override void delete()
        {
            Destination destination = new Destination();
            destination.setId(id);
            destination.delete();
        }
    }
}
