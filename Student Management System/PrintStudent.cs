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
    public partial class PrintStudent : Form
    {
        StudentClass student = new StudentClass();
        public PrintStudent()
        {
            InitializeComponent();
        }

        private void PrintStudent_Load(object sender, EventArgs e)
        {
            showData(new MySqlCommand("SELECT * FROM `student`"));
        }

        //show students in datagridview
        public void showData(MySqlCommand command)
        {
            dataGridView_student.ReadOnly = false;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            dataGridView_student.DataSource = student.getList(command);

            imageColumn = (DataGridViewImageColumn)dataGridView_student.Columns[5];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectQuery;
            if(radioButton_all.Checked)
            {
                selectQuery = "SELECT * FROM `student`";
            }
            else if(radioButton_male.Checked)
            {
                selectQuery= "SELECT * FROM `student` WHERE `Gender` = 'Male'";
            }
            else
            {
                selectQuery = "SELECT * FROM `student` WHERE `Gender` = 'Female'";
            }
            showData(new MySqlCommand(selectQuery));
        }

        private void button__printstd_Click(object sender, EventArgs e)
        {
            
            if(dataGridView_student.Rows.Count> 0)
            {
                
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    app.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dataGridView_student.Columns.Count; i++)
                    {
                        app.Cells[1, i] = dataGridView_student.Columns[i - 1].HeaderText;
                    }
                    for (int i = 1; i < dataGridView_student.Rows.Count; i++)
                    {
                        for (int j = 1; j < dataGridView_student.Columns.Count; j++)
                        {
                            app.Cells[i + 2, j + 1] = dataGridView_student.Rows[i-1].Cells[j-1].Value.ToString();
                        }
                    }

                    app.Columns.AutoFit();
                    app.Visible = true;
             }

                


             
        }
    }
}
