using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportBoard.Models
{
    internal class FlightStatus : Model
    {
        private string id;
        private string? status;

        public FlightStatus()
        {
            tableName = "flight_status";
        }

        public override void save()
        {
            string query = String.Format("INSERT INTO {0}(status) VALUES('{1}')", tableName, status);

            runQuery(query);
        }

        public override void update()
        {
            string query = String.Format("UPDATE {0} SET status='{1}' WHERE ID={2}", tableName, status, id);

            runQuery(query);
        }

        public override string getId()
        {
            return id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }

        public string getStatus()
        {
            return status ?? "none";
        }
    }
}
