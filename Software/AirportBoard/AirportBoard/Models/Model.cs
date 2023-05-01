using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using AirportBoard.Collections;

namespace AirportBoard.Models
{
    internal abstract class Model
    {
        private static string conStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "airport.accdb") + ";Persist Security Info=False;";
        private static OleDbConnection dbConnect = new OleDbConnection();
        protected string tableName;

        //Select
        protected static List<List<string>> runSelect(string query)
        {
            dbConnect.ConnectionString = conStr;
            OleDbCommand dbCmd = new OleDbCommand(query, dbConnect);

            dbConnect.Open();
            OleDbDataReader reader = dbCmd.ExecuteReader();
            List<List<string>> rows = ListParser.readerToList(reader);
            dbConnect.Close();

            return rows;
        }

        //Insert
        protected void runQuery(string query)
        {
            oleDbRunQuery(query);
        }

        protected void oleDbRunQuery(string query)
        {
            dbConnect.ConnectionString = conStr;
            OleDbCommand dbCmd = new OleDbCommand(query, dbConnect);

            dbConnect.Open();
            //MessageBox.Show(query);
            dbCmd.ExecuteNonQuery();
            dbConnect.Close();
        }

        public List<List<string>> getAll()
        {
            string query = String.Format("SELECT * FROM {0}", tableName);
            return runSelect(query);
        }

        public void delete()
        {
            string query = String.Format("DELETE FROM {0} WHERE ID={1}", tableName, getId());

            runQuery(query);
        }

        public string getTableName()
        {
            return tableName;
        }

        public abstract void save();
        public abstract void update();
        public abstract string getId();
    }
}
