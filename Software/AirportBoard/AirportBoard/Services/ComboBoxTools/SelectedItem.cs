using AirportBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportBoard.Services.ComboBoxTools
{
    internal class SelectedItem
    {
        public static void set(ComboBox comboBox, string selectedValue)
        {
            string value;
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                value = (comboBox.Items[i] as ComboBoxItem).Value.ToString();
                if (selectedValue == value)
                {
                    comboBox.SelectedIndex = i;
                    break;
                }
            }
        }
    }
}
