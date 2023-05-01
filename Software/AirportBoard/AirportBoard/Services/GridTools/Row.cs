using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportBoard.Services.GridTools
{
    internal class Row
    {
        public static bool isSelected(DataGridView gridView)
        {
            var rowsCount = gridView.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return false;

            var row = gridView.SelectedRows[0];
            if (row == null) return false;

            return true;
        }
    }
}
