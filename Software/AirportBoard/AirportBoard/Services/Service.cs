using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportBoard.Services
{
    internal abstract class Service
    {
        public abstract void setFields(Dictionary<string, string> values);

        protected string valueContains(Dictionary<string, string> values, string key)
        {
            return values.ContainsKey(key) ? values[key] : null;
        }

        public abstract void save();
        public abstract void update();
        public abstract void delete();
    }
}
