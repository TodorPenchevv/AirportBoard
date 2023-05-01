using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportBoard.Exceptions
{
    internal class DeleteException : Exception
    {
        public DeleteException() 
            : base("An error occured during UPDATE operation!")
        {
        }
    }
}
