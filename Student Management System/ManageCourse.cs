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
    public partial class ManageCourse : Form
    {
        CourseClass course = new CourseClass();
        public ManageCourse()
        {
            InitializeComponent();
        }

        private void showData()
        {
            dataGridView_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `discipline`"));
        }

        private void ManageCourse_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_curs.Clear();
            textBox_cursid.Clear();
        }

        private void button_update_Click(object sender, EventArgs e)
        {

            if (textBox_curs.Text == "" || textBox_cursid.Equals(""))
            {
                MessageBox.Show("Need course data", "Field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(textBox_cursid.Text);
                string cName = textBox_curs.Text;
                int nrcd = Convert.ToInt32(textBox_credit.Text);
                if (course.updateCourse(id,cName, nrcd))
                {
                    showData();
                    button_clear.PerformClick();
                    MessageBox.Show("Curs modificat cu succes", "Modifica curs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR: Cursul nu a  fost modificat", "Modififca curs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button__delete_Click(object sender, EventArgs e)
        {
            if (textBox_cursid.Equals(""))
            {
                MessageBox.Show("Need course data", "Field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox_cursid.Text);

                    if (course.deleteCourse(id))
                    {
                        showData();
                        button_clear.PerformClick();
                        MessageBox.Show("Curs sters cu succes", "Sterge curs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "stergere curs curs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView_course_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_course_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_cursid.Text = dataGridView_course.CurrentRow.Cells[0].Value.ToString();
            textBox_curs.Text = dataGridView_course.CurrentRow.Cells[1].Value.ToString();
            textBox_credit.Text = dataGridView_course.CurrentRow.Cells[2].Value.ToString();

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            dataGridView_course.DataSource=course.getCourse(new MySqlCommand("SELECT * FROM `discipline` WHERE CONCAT(`denumire`,`nr_credite`) LIKE '%"+ textBox_search.Text+"%'"));
            textBox_search.Clear();
        }
    }
}
