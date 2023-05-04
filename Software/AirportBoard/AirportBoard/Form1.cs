using AirportBoard.Models;
using AirportBoard.Services;
using AirportBoard.Forms;
using AirportBoard.Services.GridTools;
using System.Reflection;

namespace AirportBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadArrivasAndDepartures();
        }

        private void loadArrivasAndDepartures()
        {
            //Table.loadData(arrivalGridView, new Flight());
            //Table.loadData(departureGridView, new Flight());

            List<List<string>> rows = Flight.getAllDepartures();
            Table.loadRowsIntoGridView(departureGridView, rows);
            rows = Flight.getAllArrivals();
            Table.loadRowsIntoGridView(arrivalGridView, rows);
        }

        private void airlinesButton_Click(object sender, EventArgs e)
        {
            (new AirlinesForm()).Show();
        }

        private void citiesButton_Click(object sender, EventArgs e)
        {
            (new CitiesForm()).Show();
        }

        private void countriesButton_Click(object sender, EventArgs e)
        {
            (new CountriesForm()).Show();
        }

        private void destinationsButton_Click(object sender, EventArgs e)
        {
            (new DestinationsForm()).Show();
        }

        private void flightsButton_Click(object sender, EventArgs e)
        {
            (new FlightsForm()).Show();
        }

        private void flightStatusesButton_Click(object sender, EventArgs e)
        {
            (new StatusesForm()).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new GatesForm()).Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            loadArrivasAndDepartures();
        }
    }
}