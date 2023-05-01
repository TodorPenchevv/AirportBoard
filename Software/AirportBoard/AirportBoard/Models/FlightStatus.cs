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
            string[,] queryParams = new string[,]
            {
                {
                    "tableName", getTableName()
                },
                {
                    "status", getStatus()
                },
            };

            string query = "INSERT INTO @tableName(status) VALUES(@status)";

            runQuery(query);
        }

        public override void update()
        {
            string query = "UPDATE '" + getTableName() + "' SET status='" + getStatus() + "' WHERE ID=" + getId();

            runQuery(query);
        }

        public override string getId()
        {
            return id;
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
