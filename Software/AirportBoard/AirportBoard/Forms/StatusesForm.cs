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
    public partial class StatusesForm : Form
    {
        StatusService statusService = new StatusService();
        Dictionary<string, string> values = new Dictionary<string, string>();

        public StatusesForm()
        {
            InitializeComponent();
        }

        private void StatusesForm_Load(object sender, EventArgs e)
        {
            statusesLoadData();

            statusesGridView.RowStateChanged += new DataGridViewRowStateChangedEventHandler(statusesGridView_RowStateChanged);
        }

        private void addStatus_Click(object sender, EventArgs e)
        {
            try
            {
                values.Clear();
                values.Add("statusName", statusNameTextBox.Text);

                statusService.setFields(values);
                statusService.save();
                statusesLoadData();
            }
            catch (Exception exception)
            {
                Notification.show("Error", exception.Message);
            }
        }

        private void updateStatus_Click(object sender, EventArgs e)
        {
            try
            {
                values.Add("statusName", statusNameTextBox.Text);

                statusService.setFields(values);
                statusService.update();
                statusesLoadData();
            }
            catch (Exception exception)
            {
                Notification.show("Error", exception.Message);
            }
        }

        private void deleteStatus_Click(object sender, EventArgs e)
        {
            try
            {
                statusService.setFields(values);
                statusService.delete();
                statusesLoadData();
            }
            catch (Exception exception)
            {
                Notification.show("Error", exception.Message);
            }
        }

        private void statusesGridView_RowStateChanged(object sender, EventArgs e)
        {
            if (Row.isSelected(statusesGridView))
            {
                var row = statusesGridView.SelectedRows[0];

                values.Clear();
                string id = Convert.ToString(row.Cells["statusId"].Value);
                values.Add("id", id);

                statusNameTextBox.Text = Convert.ToString(row.Cells["statusName"].Value);
            }
        }

        private void statusesLoadData()
        {
            Table.loadData(statusesGridView, new FlightStatus());
        }
    }
}
