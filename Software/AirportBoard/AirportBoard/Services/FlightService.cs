using AirportBoard.Exceptions;
using AirportBoard.Models;

namespace AirportBoard.Services
{
    internal class FlightService : ServiceInterface
    {
        private string id;
        private string gateId;
        private string airlineId;
        private string fromDestinationId;
        private string toDestinationId;
        private string statusId;
        private string time;

        public FlightService()
        {
            getFields();
        }

        public void getFields()
        {
            //"04/21/2009 14:25:53"
        }

        public void save() {
            try
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
            catch (Exception e)
            {
                throw new InsertException();
            }
        }

        public void update()
        {
            try
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
            catch (Exception e)
            {
                throw new UpdateException();
            }
        }

        public void delete()
        {
            try
            {
                Flight flight = new Flight();
                flight.setId(id);
                flight.delete();
            }
            catch (Exception e)
            {
                throw new DeleteException();
            }
        }
    }
}
