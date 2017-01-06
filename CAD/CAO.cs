using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class CAO
    {
        private String cnx;
        private String rq_sql;
        private SqlDataAdapter dataAdapter;
        private SqlConnection connection;
        private SqlCommand command;
        private DataSet dataSet;

        public CAO()
        {
            this.cnx = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pblue\Documents\DB_A2_WS2.mdf;Integrated Security=True;Connect Timeout=30";
            this.rq_sql = "";
            this.dataAdapter = null;
            this.connection = new SqlConnection(this.cnx);
            this.command = null;
            this.dataSet = new DataSet();

        }

        public void actionRows(string rq_sql)
        {
            this.rq_sql = rq_sql;
            this.command = new SqlCommand(this.rq_sql, this.connection);
            this.connection.Open();
            this.command.ExecuteNonQuery();
            this.connection.Close();
        }

        public DataSet getRows(string rq_sql, string dataTableName)
        {
            this.rq_sql = rq_sql;
            this.command = new SqlCommand(rq_sql, connection);
            this.dataAdapter = new SqlDataAdapter(command);
            this.dataAdapter.Fill(dataSet, dataTableName);
            return this.dataSet;

        }
    }
}
