using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportBoard.Models
{
    internal class Flight : Model
    {
        private string id;
        private string? gateId;
        private string? toDestinationId;
        private string? fromDestinationId;
        private string? airlineId;
        private string? statusId;
        private string? time;

        public Flight()
        {
            tableName = "flights";
        }

        public override void save()
        {
            string query = String.Format("INSERT INTO {0} (gate_id, to_destination_id, from_destination_id, airline_id, status_id, [time]) VALUES({1}, {2}, {3}, {4}, {5}, '{6}')", 
                                            tableName, gateId, toDestinationId, fromDestinationId, airlineId, statusId, time);

            runQuery(query);
        }

        public override void update()
        {
            string query = String.Format("UPDATE {0} SET gate_id={1}, to_destination_id={2}, from_destination_id={3}, airline_id={4}, status_id={5}, [time]='{6}' WHERE ID={7}", 
                                        tableName, gateId, toDestinationId, fromDestinationId, airlineId, statusId, time, id);

            runQuery(query);
        }

        public override List<List<string>> getAllWithRelations()
        {
            string query =
                "SELECT " +
                    "flights.id, " +
                    "flights.time, " +
                    "gates.[zone] & gates.[gate_number], " +
                    "to_dst.airport, " +
                    "from_dst.airport, " +
                    "airlines.name, " +
                    "flight_status.status, " +
                    "flights.gate_id, " +
                    "flights.to_destination_id, " +
                    "flights.from_destination_id, " +
                    "flights.airline_id, " +
                    "flights.status_id " +
                "FROM ((((flights " +
                "LEFT JOIN gates " +
                "ON gates.id = flights.gate_id) " +
                "LEFT JOIN destinations to_dst " +
                "ON to_dst.id = flights.to_destination_id) " +
                "LEFT JOIN destinations from_dst " +
                "ON from_dst.id = flights.from_destination_id) " +
                "LEFT JOIN airlines " +
                "ON airlines.id = flights.airline_id) " +
                "LEFT JOIN flight_status " +
                "ON flight_status.id = flights.status_id " +
                "ORDER BY flights.time";

            return runSelect(query);
        }

        public static List<List<string>> getAllDepartures()
        {
            string query =
                "SELECT " +
                    "flights.time, " +
                    "cities.name & ' (' & to_dst.airport & ')', " +
                    "flights.id, " +
                    "gates.[zone] & gates.[gate_number], " +
                    "flight_status.status " +
                "FROM ((((flights " +
                "LEFT JOIN gates " +
                "ON gates.id = flights.gate_id) " +
                "LEFT JOIN destinations to_dst " +
                "ON to_dst.id = flights.to_destination_id)" +
                "LEFT JOIN cities " +
                "ON cities.id = to_dst.city_id) " +
                "LEFT JOIN airlines " +
                "ON airlines.id = flights.airline_id) " +
                "LEFT JOIN flight_status " +
                "ON flight_status.id = flights.status_id " +
                "WHERE from_destination_id = 0";

            return runSelect(query);
        }

        public static List<List<string>> getAllArrivals()
        {
            string query =
                "SELECT " +
                    "flights.time, " +
                    "cities.name & ' (' & from_dst.airport & ')', " +
                    "flights.id, " +
                    "gates.[zone] & gates.[gate_number], " +
                    "flight_status.status " +
                "FROM ((((flights " +
                "LEFT JOIN gates " +
                "ON gates.id = flights.gate_id) " +
                "LEFT JOIN destinations from_dst " +
                "ON from_dst.id = flights.from_destination_id)" +
                "LEFT JOIN cities " +
                "ON cities.id = from_dst.city_id) " +
                "LEFT JOIN airlines " +
                "ON airlines.id = flights.airline_id) " +
                "LEFT JOIN flight_status " +
                "ON flight_status.id = flights.status_id " +
                "WHERE to_destination_id = 0";

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

        public void setGateId(string gateId)
        {
            this.gateId = gateId;
        }

        public void setToDestinationId(string toDestinationId)
        {
            this.toDestinationId = toDestinationId;
        }

        public void setFromDestinationId(string fromDestinationId)
        {
            this.fromDestinationId = fromDestinationId;
        }

        public void setAirlineId(string airlineId)
        {
            this.airlineId = airlineId;
        }

        public void setStatusId(string statusId)
        {
            this.statusId = statusId;
        }

        public void setTime(string time)
        {
            this.time = time;
        }

        public string getGateId()
        {
            return gateId ?? "none";
        }

        public string getToDestinationId()
        {
            return toDestinationId ?? "none";
        }

        public string getFromDestinationId()
        {
            return fromDestinationId ?? "none";
        }

        public string getAirlineId()
        {
            return airlineId ?? "none";
        }

        public string getStatusId()
        {
            return statusId ?? "none";
        }

        public string getTime()
        {
            return time ?? "none";
        }
    }
}
