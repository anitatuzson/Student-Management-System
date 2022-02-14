using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Student_Management_System
{
    public partial class ManageStudentForm : Form
    {
        StudentClass student = new StudentClass();
        public ManageStudentForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void showTable()
        {
            dataGridView_student.DataSource = student.getStudentlist(new MySqlCommand("SELECT * FROM `student`"));
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView_student.Columns[5];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void dataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //display student data from student to textbox
        private void dataGridView_student_Click(object sender, EventArgs e)
        {
            textBox_id.Text = dataGridView_student.CurrentRow.Cells[0].Value.ToString();
            textBox_Fname.Text= dataGridView_student.CurrentRow.Cells[1].Value.ToString();
            textBox_Lname.Text= dataGridView_student.CurrentRow.Cells[2].Value.ToString();

            dateTimePicker1.Value=(DateTime)dataGridView_student.CurrentRow.Cells[3].Value;
            if (dataGridView_student.CurrentRow.Cells[4].Value.ToString() == "Male")
                radioButton_male.Checked = true;

            byte[] img = (byte[])dataGridView_student.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox_student.Image = Image.FromStream(ms);

        }

        private void button_clear_std_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            radioButton_male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox_student.Image = null;

        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "select Photo (*.jpg;*.png;*.gif | *.jpg;*.png;*.gif )";
            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_student.Image = Image.FromFile(opf.FileName);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            dataGridView_student.DataSource = student.searchStudent(textBox_search.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView_student.Columns[5];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
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

        private void button_update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_id.Text);
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
                    if (student.updateStudent(id,fname, lname, bdate, gender, img))
                    {
                        showTable();
                        MessageBox.Show("Datele studentilor au fost adaugat cu succes", "Update student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Camp necompletat", "Update student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
