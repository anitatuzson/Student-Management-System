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
    public partial class ScoreForm : Form
    {
        StudentClass student = new StudentClass();
        CourseClass course = new CourseClass();
        ScoreClass score = new ScoreClass();
        public ScoreForm()
        {
            InitializeComponent();
        }

        public void showScore()
        {
            dataGridView_score.DataSource = score.getScore(new MySqlCommand("SELECT `NrMatricol`, `CourseName`, `Nota` FROM `catalog`"));
        }

        private void dataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            comboBox_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `discipline`"));
            comboBox_course.DisplayMember = "denumire";
            comboBox_course.ValueMember = "denumire";
            showScore();
            dataGridView_student.DataSource = student.getList(new MySqlCommand("SELECT `NrMatricol`, `StdFirstName`,`StdLastName` FROM `student`"));
        }

        private void button__add_Click(object sender, EventArgs e)
        {


            if (textBox_studId.Equals("") || textBox_score.Equals(""))
            {
                MessageBox.Show("Need score data", "Field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int stdId = Convert.ToInt32(textBox_studId.Text);
                string cName = comboBox_course.Text;
                double nota = Convert.ToInt32(textBox_score.Text);
                if (!score.checkScore(stdId, cName))
                {

                    if (score.insertScore(stdId, cName, nota))
                    {
                        showScore();
                        button_clear.PerformClick();
                        MessageBox.Show("Nota adaugata", "Adauga nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nota nu a  fost adaugata", "Adauga curs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Pt acest curs exista deja o nota","Adauga nota",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_studId.Clear();
            textBox_score.Clear();
            comboBox_course.SelectedIndex = 0;
        }

        private void dataGridView_student_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_student_Click(object sender, EventArgs e)
        {
            textBox_studId.Text = dataGridView_student.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
