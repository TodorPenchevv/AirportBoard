using AirportBoard.Exceptions;
using AirportBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportBoard.Services
{
    internal class CountryService : ServiceInterface
    {
        private string id;
        private string name;

        public CountryService()
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
                Country country = new Country();
                country.setName(name);
                country.save();
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
                Country country = new Country();
                country.setId(id);
                country.setName(name);
                country.update();
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
                Country country = new Country();
                country.setId(id);
                country.delete();
            }
            catch (Exception e)
            {
                throw new DeleteException();
            }
        }
    }
}
