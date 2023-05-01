using AirportBoard.Exceptions;
using AirportBoard.Models;

namespace AirportBoard.Services
{
    internal class DestinationService : ServiceInterface
    {
        private string id;
        private string airport;
        private string cityId;

        public DestinationService()
        {
            getFields();
        }

        public void getFields()
        {
        }

        public void save()
        {
            try
            {
                Destination destination = new Destination();
                destination.setAirport(airport);
                destination.setCityId(cityId);
                destination.save();
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
                Destination destination = new Destination();
                destination.setId(id);
                destination.setAirport(airport);
                destination.setCityId(cityId);
                destination.update();
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
                Destination destination = new Destination();
                destination.setId(id);
                destination.delete();
            }
            catch (Exception e)
            {
                throw new DeleteException();
            }
        }
    }
}
