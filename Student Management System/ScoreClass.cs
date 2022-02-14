using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace Student_Management_System
{
    class ScoreClass
    {
        DBConnect connect = new DBConnect();

        public bool insertScore(int stdid,string courseName, double nota)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `catalog`(`NrMatricol`, `CourseName`, `Nota`) VALUES (@stid,@cn,@nota)", connect.getconnection);
            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = stdid;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@nota", MySqlDbType.VarChar).Value = nota;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
                connect.closeConnect();
            return false;

        }

        public DataTable getScore(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkScore(int stdId,string cName)
        {
            DataTable table = getScore(new MySqlCommand("SELECT * FROM `student` WHERE `NrMatricol`= '" + stdId +"' AND `CourseName`= '" + cName +"'"));
            if(table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
