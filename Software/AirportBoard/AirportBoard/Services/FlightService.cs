using AirportBoard.Logging;
using AirportBoard.Models;

namespace AirportBoard.Services
{
    internal class FlightService : Service
    {
        private string id;
        private string gateId;
        private string airlineId;
        private string fromDestinationId;
        private string toDestinationId;
        private string statusId;
        private string time;

        public FlightService() {}

        public override void setFields(Dictionary<string, string> values)
        {
            id = valueContains(values, "id");
            gateId = valueContains(values, "gateId");
            airlineId = valueContains(values, "airlineId");
            fromDestinationId = valueContains(values, "fromDestinationId");
            toDestinationId = valueContains(values, "toDestinationId");
            statusId = valueContains(values, "statusId");
            time = valueContains(values, "time"); //"04/21/2009 14:25:53"
        }

        public override void save() 
        {
            Flight flight = new Flight();
            flight.setGateId(gateId);
            flight.setAirlineId(airlineId);
            flight.setFromDestinationId(fromDestinationId);
            flight.setToDestinationId(toDestinationId);
            flight.setStatusId(statusId);
            flight.setTime(time);
            flight.save();
        }

        public override void update()
        {
            Flight flight = new Flight();
            flight.setId(id);
            flight.setGateId(gateId);
            flight.setAirlineId(airlineId);
            flight.setFromDestinationId(fromDestinationId);
            flight.setToDestinationId(toDestinationId);
            flight.setStatusId(statusId);
            flight.setTime(time);
            flight.update();
        }

        public override void delete()
        {
            Flight flight = new Flight();
            flight.setId(id);
            flight.delete();
        }
    }
}
