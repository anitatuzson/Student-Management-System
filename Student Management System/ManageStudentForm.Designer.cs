
namespace Student_Management_System
{
    partial class ManageStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button__delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_upload = new System.Windows.Forms.Button();
            this.pictureBox_student = new System.Windows.Forms.PictureBox();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_student = new System.Windows.Forms.DataGridView();
            this.textBox_Fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_clear_std = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(0, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 16);
            this.panel2.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 42);
            this.panel1.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(321, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "MANAGE STUDENTS";
            // 
            // button__delete
            // 
            this.button__delete.BackColor = System.Drawing.Color.Red;
            this.button__delete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button__delete.ForeColor = System.Drawing.Color.White;
            this.button__delete.Location = new System.Drawing.Point(780, 550);
            this.button__delete.Name = "button__delete";
            this.button__delete.Size = new System.Drawing.Size(140, 47);
            this.button__delete.TabIndex = 32;
            this.button__delete.Text = "Delete";
            this.button__delete.UseVisualStyleBackColor = false;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.OrangeRed;
            this.button_update.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(618, 550);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(156, 47);
            this.button_update.TabIndex = 31;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_upload
            // 
            this.button_upload.BackColor = System.Drawing.Color.Orange;
            this.button_upload.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_upload.ForeColor = System.Drawing.Color.White;
            this.button_upload.Location = new System.Drawing.Point(780, 489);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(140, 44);
            this.button_upload.TabIndex = 30;
            this.button_upload.Text = "Upload Photo";
            this.button_upload.UseVisualStyleBackColor = false;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // pictureBox_student
            // 
            this.pictureBox_student.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox_student.Location = new System.Drawing.Point(780, 344);
            this.pictureBox_student.Name = "pictureBox_student";
            this.pictureBox_student.Size = new System.Drawing.Size(140, 139);
            this.pictureBox_student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_student.TabIndex = 29;
            this.pictureBox_student.TabStop = false;
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton_male.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton_male.Location = new System.Drawing.Point(301, 550);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(113, 32);
            this.radioButton_male.TabIndex = 28;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Masculin";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Checked = true;
            this.radioButton_female.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton_female.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton_female.Location = new System.Drawing.Point(168, 550);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(106, 32);
            this.radioButton_female.TabIndex = 27;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Feminin";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(88, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "Sex:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 489);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(307, 34);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(23, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "Data nașterii:";
            // 
            // textBox_Lname
            // 
            this.textBox_Lname.Location = new System.Drawing.Point(168, 436);
            this.textBox_Lname.Name = "textBox_Lname";
            this.textBox_Lname.Size = new System.Drawing.Size(207, 34);
            this.textBox_Lname.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(61, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Prenume:";
            // 
            // dataGridView_student
            // 
            this.dataGridView_student.AllowUserToAddRows = false;
            this.dataGridView_student.AllowUserToDeleteRows = false;
            this.dataGridView_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_student.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_student.ColumnHeadersHeight = 24;
            this.dataGridView_student.Location = new System.Drawing.Point(12, 72);
            this.dataGridView_student.Name = "dataGridView_student";
            this.dataGridView_student.RowHeadersWidth = 65;
            this.dataGridView_student.RowTemplate.Height = 80;
            this.dataGridView_student.Size = new System.Drawing.Size(917, 250);
            this.dataGridView_student.TabIndex = 21;
            this.dataGridView_student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_student_CellContentClick);
            this.dataGridView_student.Click += new System.EventHandler(this.dataGridView_student_Click);
            // 
            // textBox_Fname
            // 
            this.textBox_Fname.Location = new System.Drawing.Point(168, 372);
            this.textBox_Fname.Name = "textBox_Fname";
            this.textBox_Fname.Size = new System.Drawing.Size(207, 34);
            this.textBox_Fname.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(88, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nume:";
            // 
            // button_clear_std
            // 
            this.button_clear_std.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_clear_std.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_clear_std.ForeColor = System.Drawing.Color.White;
            this.button_clear_std.Location = new System.Drawing.Point(447, 550);
            this.button_clear_std.Name = "button_clear_std";
            this.button_clear_std.Size = new System.Drawing.Size(165, 45);
            this.button_clear_std.TabIndex = 35;
            this.button_clear_std.Text = "Clear";
            this.button_clear_std.UseVisualStyleBackColor = false;
            this.button_clear_std.Click += new System.EventHandler(this.button_clear_std_Click);
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_search.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(807, 39);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(113, 36);
            this.button_search.TabIndex = 37;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search.Location = new System.Drawing.Point(610, 39);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(191, 34);
            this.textBox_search.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(480, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 28);
            this.label5.TabIndex = 39;
            this.label5.Text = "Numar Id:";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(592, 402);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(127, 34);
            this.textBox_id.TabIndex = 40;
            // 
            // ManageStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_clear_std);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button__delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.pictureBox_student);
            this.Controls.Add(this.radioButton_male);
            this.Controls.Add(this.radioButton_female);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Lname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_student);
            this.Controls.Add(this.textBox_Fname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageStudentForm";
            this.Text = "ManageStudentForm";
            this.Load += new System.EventHandler(this.ManageStudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button__delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.PictureBox pictureBox_student;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_student;
        private System.Windows.Forms.TextBox textBox_Fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_clear_std;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_id;
    }
}