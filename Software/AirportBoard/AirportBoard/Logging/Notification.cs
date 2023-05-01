using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportBoard.Logging
{
    internal class Notification
    {
        public static void show(string message, string title)
        {
            MessageBox.Show(title, message);
        }
    }
}
