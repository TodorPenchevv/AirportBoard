using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportBoard.Exceptions
{
    internal class InsertException : Exception
    {
        public InsertException() 
            : base("An error occured during INSERT operation!")
        {
        }
    }
}
