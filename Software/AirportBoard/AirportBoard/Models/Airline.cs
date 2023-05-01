using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportBoard.Models
{
    internal class Airline : Model
    {
        private string id;
        private string? name;
        private string? countryId;

        public Airline()
        {
            tableName = "airlines";
        }

        public override void save()
        {
            string query = String.Format("INSERT INTO {0}(name, country_id) VALUES('{1}', {2})",
                                            tableName, name, countryId);

            runQuery(query);
        }
        
        public override void update()
        {
            string query = String.Format("UPDATE {0} SET name='{1}', country_id={2} WHERE ID={3}", 
                                        tableName, name, countryId, id);

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

        public void setName(string name)
        {
            this.name = name;
        }

        public void setCountryId(string countryId)
        {
            this.countryId = countryId;
        }

        public string getName()
        {
            return name ?? "none";
        }

        public string getCountryId()
        {
            return countryId ?? "none";
        }
    }
}
