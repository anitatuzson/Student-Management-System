using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;



namespace Student_Management_System
{
    class DBConnect
    {
        MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=studentdb");
        public MySqlConnection getconnection
        {
            get
            {
                return connect;
            }
        }

        //create a function to open connection
        public void openConnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }

        //create a function to close connection
        public void closeConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }

      
    }
}
