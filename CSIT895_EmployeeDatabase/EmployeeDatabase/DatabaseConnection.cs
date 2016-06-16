using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeDatabase
{
    class DatabaseConnection
    {
        private string _sqlString;
        private string _connectionString;
        SqlDataAdapter _dataAdapter;

        public string SQL {
            set { _sqlString = value; }
        }

        public string ConnectionString
        {
            set { _connectionString = value; }
        }

        public DataSet GetConnection
        {
            get { return myDataSet();  }
        }

        private DataSet myDataSet()
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();

            _dataAdapter = new SqlDataAdapter(_sqlString, conn);
            DataSet data_set = new DataSet();
            _dataAdapter.Fill(data_set, "Table_Data_1");
            conn.Close();

            return data_set;
        }

        /// <summary>
        /// Updates the current database record
        /// </summary>
        /// <param name="ds">The dataset that is to be updated</param>
        public void UpdateDatabase(DataSet ds)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(_dataAdapter);
            cb.DataAdapter.Update(ds.Tables[0]);
        }
    }
}
