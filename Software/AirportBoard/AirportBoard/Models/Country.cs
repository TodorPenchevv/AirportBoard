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
            string query = String.Format("INSERT INTO {0}(name) VALUES('{1}')", tableName, name);

            runQuery(query);
        }

        public override void update()
        {
            string query = String.Format("UPDATE {0} SET name='{1}' WHERE ID={2}", tableName, name, id);

            runQuery(query);
        }

        public override List<List<string>> getAll()
        {
            string query = String.Format("SELECT * FROM {0} ORDER BY name", tableName);
            return runSelect(query);
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

        public string getName()
        {
            return name ?? "none";
        }
    }
}
