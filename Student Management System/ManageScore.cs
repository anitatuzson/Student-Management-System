using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Management_System
{
    public partial class ManageScore : Form
    {
        StudentClass student = new StudentClass();
        CourseClass course = new CourseClass();
        ScoreClass score = new ScoreClass();
      public ManageScore()
        {
            InitializeComponent();
        }

        private void ManageScore_Load(object sender, EventArgs e)
        {
            comboBox_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `catalog"));
            comboBox_course.DisplayMember = "CourseName";
            comboBox_course.ValueMember = "CourseName";
            //showScore();
            //dataGridView_student.DataSource = student.getList(new MySqlCommand("SELECT `NrMatricol`, `StdFirstName`,`StdLastName` FROM `student`"));
        }

        public void showScore()
        {
            dataGridView_student.DataSource = score.getScore(new MySqlCommand("SELECT `NrMatricol`, `CourseName`, `Nota` FROM `catalog`"));
        }
    }
}
