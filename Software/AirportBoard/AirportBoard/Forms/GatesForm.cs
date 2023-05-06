using AirportBoard.Logging;
using AirportBoard.Models;
using AirportBoard.Services;
using AirportBoard.Services.GridTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportBoard.Forms
{
    public partial class GatesForm : Form
    {
        GateService gateService = new GateService();
        Dictionary<string, string> values = new Dictionary<string, string>();

        public GatesForm()
        {
            InitializeComponent();
        }

        private void GatesForm_Load(object sender, EventArgs e)
        {
            gatesLoadData();

            gatesGridView.RowStateChanged += new DataGridViewRowStateChangedEventHandler(gatesGridView_RowStateChanged);
        }

        private void addGate_Click(object sender, EventArgs e)
        {
            try
            {
                values.Clear();
                getFieldValues();
                gateService.setFields(values);
                gateService.save();
                gatesLoadData();
            }
            catch (Exception exception)
            {
                Notification.show("Error", exception.Message);
            }
        }

        private void updateGate_Click(object sender, EventArgs e)
        {
            try
            {
                getFieldValues();
                gateService.setFields(values);
                gateService.update();
                gatesLoadData();
            }
            catch (Exception exception)
            {
                Notification.show("Error", exception.Message);
            }
        }

        private void getFieldValues()
        {
            values.Add("zone", gateZoneTextBox.Text);
            values.Add("number", gateNumberTextBox.Text);

            gateService.setFields(values);
        }

        private void deleteGate_Click(object sender, EventArgs e)
        {
            try
            {
                gateService.setFields(values);
                gateService.delete();
                gatesLoadData();
            }
            catch (Exception exception)
            {
                Notification.show("Error", exception.Message);
            }
        }

        private void gatesGridView_RowStateChanged(object sender, EventArgs e)
        {
            if (Row.isSelected(gatesGridView))
            {
                var row = gatesGridView.SelectedRows[0];

                values.Clear();
                string id = Convert.ToString(row.Cells["gateId"].Value);
                values.Add("id", id);

                gateZoneTextBox.Text = Convert.ToString(row.Cells["gateZone"].Value);
                gateNumberTextBox.Text = Convert.ToString(row.Cells["gateNumber"].Value);
            }
        }

        private void gatesLoadData()
        {
            Table.loadData(gatesGridView, new Gate());
        }
    }
}
