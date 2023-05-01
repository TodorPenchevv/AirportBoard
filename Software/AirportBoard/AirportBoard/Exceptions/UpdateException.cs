using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportBoard.Exceptions
{
    internal class UpdateException : Exception
    {
        public UpdateException() 
            : base("An error occured during DELETE operation!")
        {
        }
    }
}
