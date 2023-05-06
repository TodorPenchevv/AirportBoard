using AirportBoard.Logging;
using AirportBoard.Models;
using AirportBoard.Services;
using AirportBoard.Services.ComboBoxTools;
using AirportBoard.Services.GridTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AirportBoard.Forms
{
    public partial class FlightsForm : Form
    {
        FlightService flightService = new FlightService();
        Dictionary<string, string> values = new Dictionary<string, string>();

        public FlightsForm()
        {
            InitializeComponent();
        }

        private void FlightsForm_Load(object sender, EventArgs e)
        {
            loadFlightsData();
            loadGates();
            loadDestinations();
            loadAirlines();
            loadStatuses();

            flightsGridView.RowStateChanged += new DataGridViewRowStateChangedEventHandler(flightsGridView_RowStateChanged);
        }

        private void addFlight_Click(object sender, EventArgs e)
        {
            try
            {
                values.Clear();
                getFieldValues();

                flightService.setFields(values);
                flightService.save();
                loadFlightsData();
            }
            catch (Exception exception)
            {
                Notification.show("Error", exception.Message);
            }
        }

        private void updateFlight_Click(object sender, EventArgs e)
        {
            try
            {
                getFieldValues();

                flightService.setFields(values);
                flightService.update();
                loadFlightsData();
            }
            catch (Exception exception)
            {
                Notification.show("Error", exception.Message);
            }
        }

        private void deleteFlight_Click(object sender, EventArgs e)
        {
            try
            {
                flightService.setFields(values);
                flightService.delete();
                loadFlightsData();
            }
            catch (Exception exception)
            {
                Notification.show("Error", exception.Message);
            }
        }

        private void flightsGridView_RowStateChanged(object sender, EventArgs e)
        {
            if (Row.isSelected(flightsGridView))
            {
                var row = flightsGridView.SelectedRows[0];

                values.Clear();
                string id = Convert.ToString(row.Cells["flightId"].Value);
                values.Add("id", id);

                string gateId = Convert.ToString(row.Cells["flightGateId"].Value);
                SelectedItem.set(gateComboBox, gateId);

                string countryId = Convert.ToString(row.Cells["flightFromDestinationId"].Value);
                SelectedItem.set(fromComboBox, countryId);

                countryId = Convert.ToString(row.Cells["flightToDestinationId"].Value);
                SelectedItem.set(toComboBox, countryId);

                string statusId = Convert.ToString(row.Cells["flightStatusId"].Value);
                SelectedItem.set(statusComboBox, statusId);

                string airlineId = Convert.ToString(row.Cells["flightAirlineId"].Value);
                SelectedItem.set(airlinesComboBox, airlineId);

                string time = Convert.ToString(row.Cells["flightTime"].Value);
            }
        }

        private void loadFlightsData()
        {
            Table.loadData(flightsGridView, new Flight());
        }

        private void loadGates()
        {
            List<List<string>> rows = (new Gate()).getAll();

            foreach (List<string> row in rows)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = row[1] + row[2]; // Gate zone + Gate number
                item.Value = row[0]; // Gate ID
                gateComboBox.Items.Add(item);
            }

            gateComboBox.SelectedIndex = 0;
        }

        private void loadDestinations()
        {
            List<List<string>> rows = (new Destination()).getAll();

            ComboBoxItem item = new ComboBoxItem();
            item.Text = ""; // Destination airport
            item.Value = 0; // Destination ID
            fromComboBox.Items.Add(item);
            toComboBox.Items.Add(item);

            foreach (List<string> row in rows)
            {
                item = new ComboBoxItem();
                item.Text = row[1]; // Destination airport
                item.Value = row[0]; // Destination ID
                fromComboBox.Items.Add(item);
                toComboBox.Items.Add(item);
            }

            fromComboBox.SelectedIndex = 0;
            toComboBox.SelectedIndex = 0;
        }

        private void loadAirlines()
        {
            List<List<string>> rows = (new Airline()).getAll();

            foreach (List<string> row in rows)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = row[1]; // Airline name
                item.Value = row[0]; // Airline ID
                airlinesComboBox.Items.Add(item);
            }

            airlinesComboBox.SelectedIndex = 0;
        }

        private void loadStatuses()
        {
            List<List<string>> rows = (new FlightStatus()).getAll();

            foreach (List<string> row in rows)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = row[1]; // Status name
                item.Value = row[0]; // Status ID
                statusComboBox.Items.Add(item);
            }

            statusComboBox.SelectedIndex = 0;
        }

        private void getFieldValues()
        {
            string gateId = (gateComboBox.SelectedItem as ComboBoxItem).Value.ToString(); // Get selected gate id
            //if from and to is set -> Error
            string fromId = (fromComboBox.SelectedItem as ComboBoxItem).Value.ToString();
            string toId = (toComboBox.SelectedItem as ComboBoxItem).Value.ToString();
            string airlineId = (airlinesComboBox.SelectedItem as ComboBoxItem).Value.ToString();
            string statusId = (statusComboBox.SelectedItem as ComboBoxItem).Value.ToString();
            string date = flightDateTimePicker.Value.ToString("MM/dd/yyyy");
            string hour = hourNumericUpDown.Value.ToString();
            string minutes = minutesNumericUpDown.Value.ToString();

            values.Add("gateId", gateId);
            values.Add("fromDestinationId", fromId);
            values.Add("toDestinationId", toId);
            values.Add("airlineId", airlineId);
            values.Add("statusId", statusId);
            values.Add("time", date + " " + hour + ":" + minutes + ":00");
        }
    }
}
