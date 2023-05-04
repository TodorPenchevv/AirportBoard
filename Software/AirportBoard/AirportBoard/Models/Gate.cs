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
            string query = String.Format("INSERT INTO {0} ([zone], [gate_number]) VALUES('{1}', {2})", tableName, zone, number);

            runQuery(query);
        }

        public override void update()
        {
            string query = String.Format("UPDATE {0} SET [zone]='{1}', [gate_number]={2} WHERE ID={3}", tableName, zone, number, id);

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
