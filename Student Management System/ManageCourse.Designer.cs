
namespace Student_Management_System
{
    partial class ManageCourse
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button__delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.dataGridView_course = new System.Windows.Forms.DataGridView();
            this.textBox_cursid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_curs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_credit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_course)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 42);
            this.panel1.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(321, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "MANAGE COURSES";
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search.Location = new System.Drawing.Point(610, 48);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(191, 27);
            this.textBox_search.TabIndex = 45;
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_search.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(807, 42);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(113, 36);
            this.button_search.TabIndex = 44;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(0, 427);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 16);
            this.panel2.TabIndex = 43;
            // 
            // button__delete
            // 
            this.button__delete.BackColor = System.Drawing.Color.Red;
            this.button__delete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button__delete.ForeColor = System.Drawing.Color.White;
            this.button__delete.Location = new System.Drawing.Point(780, 553);
            this.button__delete.Name = "button__delete";
            this.button__delete.Size = new System.Drawing.Size(140, 47);
            this.button__delete.TabIndex = 41;
            this.button__delete.Text = "Delete";
            this.button__delete.UseVisualStyleBackColor = false;
            this.button__delete.Click += new System.EventHandler(this.button__delete_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.OrangeRed;
            this.button_update.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(618, 553);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(156, 47);
            this.button_update.TabIndex = 40;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // dataGridView_course
            // 
            this.dataGridView_course.AllowUserToAddRows = false;
            this.dataGridView_course.AllowUserToDeleteRows = false;
            this.dataGridView_course.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_course.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_course.ColumnHeadersHeight = 24;
            this.dataGridView_course.Location = new System.Drawing.Point(0, 75);
            this.dataGridView_course.Name = "dataGridView_course";
            this.dataGridView_course.RowHeadersWidth = 85;
            this.dataGridView_course.RowTemplate.Height = 80;
            this.dataGridView_course.Size = new System.Drawing.Size(929, 346);
            this.dataGridView_course.TabIndex = 21;
            this.dataGridView_course.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_course_CellClick);
            this.dataGridView_course.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_course_CellContentClick);
            // 
            // textBox_cursid
            // 
            this.textBox_cursid.Location = new System.Drawing.Point(207, 536);
            this.textBox_cursid.Name = "textBox_cursid";
            this.textBox_cursid.Size = new System.Drawing.Size(207, 27);
            this.textBox_cursid.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(121, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 48;
            this.label2.Text = "Id curs:";
            // 
            // textBox_curs
            // 
            this.textBox_curs.Location = new System.Drawing.Point(207, 472);
            this.textBox_curs.Name = "textBox_curs";
            this.textBox_curs.Size = new System.Drawing.Size(207, 27);
            this.textBox_curs.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(82, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 28);
            this.label1.TabIndex = 46;
            this.label1.Text = "Nume curs:";
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.Sienna;
            this.button_clear.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(456, 553);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(156, 47);
            this.button_clear.TabIndex = 50;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox_credit
            // 
            this.textBox_credit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_credit.Location = new System.Drawing.Point(594, 476);
            this.textBox_credit.Name = "textBox_credit";
            this.textBox_credit.Size = new System.Drawing.Size(207, 27);
            this.textBox_credit.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(469, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 51;
            this.label3.Text = "Nr credite:";
            // 
            // ManageCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.textBox_credit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.textBox_cursid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_curs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button__delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.dataGridView_course);
            this.Name = "ManageCourse";
            this.Text = "ManageCourse";
            this.Load += new System.EventHandler(this.ManageCourse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_course)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button__delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.DataGridView dataGridView_course;
        private System.Windows.Forms.TextBox textBox_cursid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_curs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_credit;
        private System.Windows.Forms.Label label3;
    }
}