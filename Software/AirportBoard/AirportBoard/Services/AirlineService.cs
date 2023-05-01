using AirportBoard.Exceptions;
using AirportBoard.Models;

namespace AirportBoard.Services
{
    internal class AirlineService : ServiceInterface
    {
        private string id;
        private string name;
        private string countryId;

        public AirlineService()
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
                Airline airline = new Airline();
                airline.setName(name);
                airline.setCountryId(countryId);
                airline.save();
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
                Airline airline = new Airline();
                airline.setId(id);
                airline.setName(name);
                airline.setCountryId(countryId);
                airline.update();
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
                Airline airline = new Airline();
                airline.setId(id);
                airline.delete();
            }
            catch (Exception e)
            {
                throw new DeleteException();
            }
        }
    }
}
