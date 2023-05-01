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
            try
            {
                FlightStatus status = new FlightStatus();
                status.setStatus(statusName);
                status.save();
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
                FlightStatus status = new FlightStatus();
                status.setId(id);
                status.setStatus(statusName);
                status.update();
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
                FlightStatus status = new FlightStatus();
                status.setId(id);
                status.delete();
            }
            catch (Exception e)
            {
                Notification.show("Error", e.Message);
            }
        }
    }
}
