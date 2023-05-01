using AirportBoard.Exceptions;
using AirportBoard.Models;

namespace AirportBoard.Services
{
    internal class CityService : ServiceInterface
    {
        private string id;
        private string name;
        private string countryId;

        public CityService()
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
                City city = new City();
                city.setName(name);
                city.setCountryId(countryId);
                city.save();
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
                City city = new City();
                city.setId(id);
                city.setName(name);
                city.setCountryId(countryId);
                city.update();
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
                City city = new City();
                city.setId(id);
                city.delete();
            }
            catch (Exception e)
            {
                throw new DeleteException();
            }
        }
    }
}
