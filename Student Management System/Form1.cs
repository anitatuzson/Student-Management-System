using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class Form1 : Form
    {

        StudentClass student = new StudentClass();
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //statusstudent
            hideSubmenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //managecourse
            openChildForm(new ManageCourse());
            hideSubmenu();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
     
        private void customizeDesign()
        {
            panel_submenustudent.Visible = false;
            panel_courseSubmenu.Visible = false;
            panel_scoreSubmenu.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panel_submenustudent.Visible == true)
                panel_submenustudent.Visible = false;
            if (panel_courseSubmenu.Visible == true)
                panel_courseSubmenu.Visible = false;
            if (panel_scoreSubmenu.Visible == true)
                panel_scoreSubmenu.Visible = false;

        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void button_student_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_submenustudent);
        }

        private void button_registration_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());
            hideSubmenu();
        }

        private void button_managestd_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStudentForm());
            hideSubmenu();
        }

        private void button_printstd_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintStudent());
            hideSubmenu();
        }

        private void button_course_Click(object sender, EventArgs e)
        {
           
            showSubmenu(panel_courseSubmenu);
        }

        private void button_newCourse_Click(object sender, EventArgs e)
        {
             openChildForm(new CourseForm());
            hideSubmenu();
        }

        private void button_courseStatus_Click(object sender, EventArgs e)
        {

            hideSubmenu();
        }

        private void button_coursePrint_Click(object sender, EventArgs e)
        {

            hideSubmenu();
        }

        private void button_score_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_scoreSubmenu);

        }

        private void button_newScore_Click(object sender, EventArgs e)
        {
            openChildForm(new ScoreForm());

            hideSubmenu();
        }

        private void button_manageScore_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageScore());

            hideSubmenu();
        }

        private void button_scoreStatus_Click(object sender, EventArgs e)
        {

            hideSubmenu();
        }

        private void button_printScore_Click(object sender, EventArgs e)
        {

            hideSubmenu();
        }

        



        //to show register in main form
        public Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_exit_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
            studentCount();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentCount();
        }

        private void studentCount()
        {
            label_totalstd.Text = "Total Students: " + student.totalStudent();
            label_malestd.Text = "Male: " + student.maleStudent();
            label_femalestd.Text = "Female: " + student.femaleStudent();

        }
    }
}
