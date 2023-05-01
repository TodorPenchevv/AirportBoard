using AirportBoard.Models;
using AirportBoard.Services;
using AirportBoard.Forms;

namespace AirportBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void button7_Click(object sender, EventArgs e)
        {
            (new GatesForm()).Show();
        }
    }
}