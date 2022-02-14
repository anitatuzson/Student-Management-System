using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace Student_Management_System
{
    class CourseClass
    {
        DBConnect connect = new DBConnect();

        public bool insertCourse(string cName, int nrcrd)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `discipline`(`denumire`, `nr_credite`) VALUES (@cn, @nrc)",connect.getconnection);
            //@cn@nrc
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@nrc", MySqlDbType.VarChar).Value = nrcrd;

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

        public DataTable getCourse(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool updateCourse(int id,string cName, int nrcrd)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `discipline` SET `cod_disciplina`=@id,`denumire`=@nc,`nr_credite`=@ncr ", connect.getconnection);
            //@cn@nrc
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@nrc", MySqlDbType.VarChar).Value = nrcrd;

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

        public bool deleteCourse(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `discipline` WHERE `cod_disciplina`=@id", connect.getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
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
    }
}
