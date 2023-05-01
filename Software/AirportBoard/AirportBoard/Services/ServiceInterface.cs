using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportBoard.Services
{
    internal interface ServiceInterface
    {
        void getFields();
        void save();
        void update();
        void delete();
    }
}
