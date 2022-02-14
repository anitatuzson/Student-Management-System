using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Management_System
{
    public partial class RegisterForm : Form
    {
        StudentClass student = new StudentClass();
        public RegisterForm()
        {
            InitializeComponent();
            showTable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "select Photo (*.jpg;*.png;*.gif | *.jpg;*.png;*.gif )";
            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_student.Image = Image.FromFile(opf.FileName);
        }

      
        bool verify()
        {
            if ((textBox_Fname.Text == "") || (textBox_Lname).Text == "" ||
                (pictureBox_student.Image == null))
            {
                return false;

            }
            else
                return true;
        }


       

        public void showTable()
        {
            dataGridView_student.DataSource = student.getStudentlist(new MySqlCommand("SELECT * FROM `student`"));
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn= (DataGridViewImageColumn) dataGridView_student.Columns[5];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            radioButton_male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox_student.Image = null;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string fname = textBox_Fname.Text;
            string lname = textBox_Lname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string gender = radioButton_female.Checked ? "Female" : "Male";


            //trebuie verificat varsta studentilor

            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 18 || (this_year - born_year) > 130)
            {
                MessageBox.Show("Varsta studentului trebuie sa fie intre 18 si 130 de ani", "Varsta invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (verify())
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox_student.Image.Save(ms, pictureBox_student.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    if (student.insertStudent(fname, lname, bdate, gender, img))
                    {
                        showTable();
                        MessageBox.Show("Student nou adaugat cu succes", "Adauga student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Camp necompletat", "Adauga student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        
        }
    }
}
