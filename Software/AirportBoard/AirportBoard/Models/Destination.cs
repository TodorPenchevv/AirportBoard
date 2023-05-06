using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AirportBoard.Models
{
    internal class Destination : Model
    {
        private string id;
        private string? airport;
        private string? cityId;

        public Destination()
        {
            tableName = "destinations";
        }

        public override void save()
        {
            string query = String.Format("INSERT INTO {0}(airport, city_id) VALUES('{1}', {2})",
                                        tableName, airport, cityId);

            runQuery(query);
        }

        public override void update()
        {
            string query = String.Format("UPDATE {0} SET airport='{1}', city_id={2} WHERE ID={3}",
                                            tableName, airport, cityId, id);

            runQuery(query);
        }

        public override List<List<string>> getAllWithRelations()
        {
            string query =
                "SELECT destinations.id, destinations.airport, destinations.city_id, cities.name, countries.name " +
                "FROM (destinations " +
                "LEFT JOIN cities " +
                "ON cities.id = destinations.city_id) " +
                "LEFT JOIN countries " +
                "ON countries.id = cities.country_id " +
                "ORDER BY countries.name, cities.name, destinations.airport ";

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

        public void setAirport(string airport)
        {
            this.airport = airport;
        }

        public void setCityId(string cityId)
        {
            this.cityId = cityId;
        }

        public string getAirport()
        {
            return airport ?? "none";
        }

        public string getCityId()
        {
            return cityId ?? "none";
        }
    }
}
