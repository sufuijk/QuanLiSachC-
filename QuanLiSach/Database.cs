using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace QuanLiSach
{
    class Database
    {
        private static Database instance;
        private SqlDataAdapter adt;
        private SqlCommandBuilder cmd;
        private SqlConnection connect;

        public static Database Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }
        private Database()
        {
            string connectionString = @"Data Source=SUFUIJK\SQLEXPRESS;Initial Catalog=QUANLISACH;Integrated Security=True";
            connect = new SqlConnection(connectionString);
        }

        public DataTable LoadData(string query)
        {
            this.connect.Open();
            DataTable table = new DataTable();
            adt = new SqlDataAdapter(query, this.connect);
            adt.Fill(table);
            this.connect.Close();
            return table;
        }

        public void Update(DataTable table)
        {
            this.cmd = new SqlCommandBuilder(this.adt);
            this.adt.Update(table);
        }

    }
}
