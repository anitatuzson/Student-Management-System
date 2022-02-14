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
    public partial class CourseForm : Form
    {
        CourseClass course = new CourseClass();
        public CourseForm()
        {
            InitializeComponent();
        }

        private void button__addc_Click(object sender, EventArgs e)
        {

            if (textBox_curs.Text == "")
            {
                MessageBox.Show("Need course data", "Field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cName = textBox_curs.Text;
                int nrcd = Convert.ToInt32(textBox_credit.Text);
                if (course.insertCourse(cName, nrcd))
                {
                    showData();
                    button_clearc.PerformClick();
                    MessageBox.Show("Curs nou adaugat", "Adauga curs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cursul nu a  fost adaugat", "Adauga curs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_clearc_Click(object sender, EventArgs e)
        {
            textBox_curs.Clear();
            textBox_credit.Clear();
        }

        private void showData()
        {
            dataGridView_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `discipline`"));
        }
        private void CourseForm_Load(object sender, EventArgs e)
        {
            showData();
        }
    }
}
