using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportBoard.Models
{
    internal class Country : Model
    {
        private string id;
        private string? name;

        public Country()
        {
            tableName = "countries";
        }

        public override void save()
        {
            string[,] queryParams = new string[,]
            {
                {
                    "tableName", getTableName()
                },
                {
                    "name", getName()
                },
            };

            string query = "INSERT INTO @tableName(name) VALUES(@name)";

            runQuery(query);
        }

        public override void update()
        {
            string query = "UPDATE '" + getTableName() + "' SET name='" + getName() + "' WHERE ID=" + getId();

            runQuery(query);
        }

        public override string getId()
        {
            return id;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name ?? "none";
        }
    }
}
