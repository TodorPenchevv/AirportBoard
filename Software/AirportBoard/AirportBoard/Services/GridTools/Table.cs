using AirportBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportBoard.Services.GridTools
{
    internal class Table
    {
        public static void loadData(DataGridView grid, Model model)
        {
            List<List<string>> rows = model.getAll();

            grid.Rows.Clear();

            List<string> newRow;
            foreach (List<string> row in rows)
            {
                newRow = new List<string>();

                foreach (string field in row)
                {
                    newRow.Add(field);
                }

                grid.Rows.Add(newRow.ToArray());
            }
        }
    }
}
