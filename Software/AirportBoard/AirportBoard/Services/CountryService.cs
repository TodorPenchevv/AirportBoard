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
            Country country = new Country();
            country.setName(name);
            country.save();
        }

        public override void update()
        {
            Country country = new Country();
            country.setId(id);
            country.setName(name);
            country.update();
        }

        public override void delete()
        {
            Country country = new Country();
            country.setId(id);
            country.delete();
        }
    }
}
