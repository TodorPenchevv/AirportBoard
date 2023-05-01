using AirportBoard.Models;

namespace AirportBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addFlight_Click(object sender, EventArgs e)
        {
            Flight flight = new Flight();
            flight.setGateId("1");
            flight.setAirlineId("1");
            flight.setFromDestinationId("1");
            flight.setToDestinationId("2");
            flight.setStatusId("1");
            flight.setTime("04/21/2009 14:25:53");
            flight.save();

        }

        private void updateFlight_Click(object sender, EventArgs e)
        {
            Flight flight = new Flight();
            flight.setId("7");
            flight.setGateId("1");
            flight.setAirlineId("1");
            flight.setFromDestinationId("1");
            flight.setToDestinationId("2");
            flight.setStatusId("1");
            flight.setTime("04/21/2008 14:25:53");
            flight.update();
        }

        private void deleteFlight_Click(object sender, EventArgs e)
        {
            Flight flight = new Flight();
            flight.setId("7");
            flight.delete();
        }

        private void addDestination_Click(object sender, EventArgs e)
        {
            Destination destination = new Destination();
            destination.setAirport("Airport Varna");
            destination.setCityId("1");
            destination.save();
        }

        private void updateDestination_Click(object sender, EventArgs e)
        {
            Destination destination = new Destination();
            destination.setId("1");
            destination.setAirport("Airport Sofia");
            destination.setCityId("1");
            destination.update();
        }

        private void deleteDestination_Click(object sender, EventArgs e)
        {
            Destination destination = new Destination();
            destination.setId("1");
            destination.delete();

        }

        private void addCity_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.setName("Varna");
            city.setCountryId("1");
            city.save();
        }

        private void updateCity_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.setId("1");
            city.setName("Sofia");
            city.setCountryId("1");
            city.update();
        }

        private void deleteCity_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.setId("1");
            city.setName("Sofia");
            city.setCountryId("1");
            city.delete();
        }

        private void addCountry_Click(object sender, EventArgs e)
        {

        }

        private void updateCountry_Click(object sender, EventArgs e)
        {

        }

        private void deleteCountry_Click(object sender, EventArgs e)
        {

        }

        private void addAirline_Click(object sender, EventArgs e)
        {
            Airline airline = new Airline();
            airline.setName("Ryanair");
            airline.setCountryId("1");
            airline.save();
        }

        private void updateAirline_Click(object sender, EventArgs e)
        {
            Airline airline = new Airline();
            airline.setId("2");
            airline.setName("Ryanair");
            airline.setCountryId("2");
            airline.update();

        }

        private void deleteAirline_Click(object sender, EventArgs e)
        {
            Airline airline = new Airline();
            airline.setId("2");
            airline.delete();
        }
    }
}