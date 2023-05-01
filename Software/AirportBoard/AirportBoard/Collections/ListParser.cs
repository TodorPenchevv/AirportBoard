using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportBoard.Collections
{
    internal class ListParser
    {
        //reader to array
        public static List<List<string>> readerToList(OleDbDataReader reader)
        {
            int count = reader.FieldCount;
            List<List<string>> rows = new List<List<string>>();

            while (reader.Read())
            {
                List<string> newRow = new List<string>();

                for (int i = 0; i < count; i++)
                {
                    newRow.Add(reader.GetValue(i).ToString());
                }

                rows.Add(newRow);
            }

            return rows;
        }
    }
}
