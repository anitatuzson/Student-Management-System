using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Student_Management_System
{
    class StudentClass
    {
        DBConnect connect = new DBConnect();

        public bool insertStudent(string fname, string lname, DateTime bdate, string gender, byte [] img)
        {
         
            MySqlCommand command = new MySqlCommand("INSERT INTO `student`(`StdFirstName`, `StdLastName`, `Birthdate`, `Gender`, `Photo`) VALUES(@fn, @ln, @bd, @gd, @img)",connect.getconnection);
            //@fn, @ln, @bd, @gd, @img
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            connect.openConnect();
            if(command.ExecuteNonQuery()==1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        public DataTable getStudentlist(MySqlCommand command)
        {
             command.Connection= connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public string exeCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query,connect.getconnection);
            connect.openConnect();
            string count = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return count;
        }
        //total student
        public string totalStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student");
        }

        //male students S
        public string maleStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student WHERE `Gender` = 'Male'");
        }

        public string femaleStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student WHERE `Gender` = 'Female'");
        }

        public DataTable searchStudent(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student` WHERE CONCAT(`StdFirstName`,`StdLastName`) LIKE '%"+ searchdata +"%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool updateStudent(int id,string fname, string lname, DateTime bdate, string gender, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `student` SET `StdFirstName`=@fn,`StdLastName`=@ln,`Birthdate`= @bd,`Gender`=@gd,`Photo`=@img WHERE `NrMatricol`=@id", connect.getconnection);
            //@fn, @ln, @bd, @gd, @img
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
            //UPDATE `student` SET `StdFirstName`= @fn,`StdLastName`= @ln,`Birthdate`= @bd,`Gender`=
            //@gd,`Photo`= @img WHERE `NrMatricol`= @id 2:20:10
        }

        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
