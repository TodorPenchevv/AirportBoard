using AirportBoard.Logging;
using AirportBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AirportBoard.Services
{
    internal class StatusService : Service
    {
        private string id;
        private string statusName;

        public StatusService() {}

        public override void setFields(Dictionary<string, string> values)
        {
            id = valueContains(values, "id");
            statusName = valueContains(values, "statusName");
        }

        public override void save()
        {
            FlightStatus status = new FlightStatus();
            status.setStatus(statusName);
            status.save();
        }

        public override void update()
        {
            FlightStatus status = new FlightStatus();
            status.setId(id);
            status.setStatus(statusName);
            status.update();
        }

        public override void delete()
        {
            FlightStatus status = new FlightStatus();
            status.setId(id);
            status.delete();
        }
    }
}
