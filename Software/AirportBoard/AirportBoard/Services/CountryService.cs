using AirportBoard.Exceptions;
using AirportBoard.Logging;
using AirportBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportBoard.Services
{
    internal class CountryService : Service
    {
        private string? id;
        private string? name;

        public CountryService() {}

        public override void setFields(Dictionary<string, string> values)
        {
            id = valueContains(values, "id");
            name = valueContains(values, "name");
        }

        public override void save()
        {
            try
            {
                Country country = new Country();
                country.setName(name);
                country.save();
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
                Country country = new Country();
                country.setId(id);
                country.setName(name);
                country.update();
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
                Country country = new Country();
                country.setId(id);
                country.delete();
            }
            catch (Exception e)
            {
                Notification.show("Error", e.Message);
            }
        }
    }
}
