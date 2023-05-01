using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportBoard.Models
{
    internal class Gate : Model
    {
        private string id;
        private string? zone;
        private string? number;

        public Gate()
        {
            tableName = "gates";
        }

        public override void save()
        {
            string[,] queryParams = new string[,]
            {
                {
                    "tableName", getTableName()
                },
                {
                    "zone", getZone()
                },
                {
                    "number", getNumber()
                },
            };

            string query = "INSERT INTO @tableName(zone, number) VALUES(@zone, @number)";

            runQuery(query);
        }

        public override void update()
        {
            string query = "UPDATE '" + getTableName() + "' SET zone='" + getZone() + "', number='" + getNumber() + "' WHERE ID=" + getId();

            runQuery(query);
        }

        public override string getId()
        {
            return id;
        }

        public void setZone(string zone)
        {
            this.zone = zone;
        }

        public void setNumber(string number)
        {
            this.number = number;
        }

        public string getZone()
        {
            return zone ?? "none";
        }

        public string getNumber()
        {
            return number ?? "none";
        }
    }
}
