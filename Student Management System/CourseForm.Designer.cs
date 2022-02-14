
namespace Student_Management_System
{
    partial class CourseForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_course = new System.Windows.Forms.DataGridView();
            this.button__addc = new System.Windows.Forms.Button();
            this.button_clearc = new System.Windows.Forms.Button();
            this.textBox_curs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_credit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_course)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(382, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "CURSURI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 42);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(3, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 16);
            this.panel2.TabIndex = 36;
            // 
            // dataGridView_course
            // 
            this.dataGridView_course.AllowUserToAddRows = false;
            this.dataGridView_course.AllowUserToDeleteRows = false;
            this.dataGridView_course.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_course.ColumnHeadersHeight = 24;
            this.dataGridView_course.Location = new System.Drawing.Point(3, 45);
            this.dataGridView_course.Name = "dataGridView_course";
            this.dataGridView_course.RowHeadersWidth = 65;
            this.dataGridView_course.RowTemplate.Height = 80;
            this.dataGridView_course.Size = new System.Drawing.Size(929, 377);
            this.dataGridView_course.TabIndex = 35;
            // 
            // button__addc
            // 
            this.button__addc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button__addc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button__addc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button__addc.ForeColor = System.Drawing.Color.White;
            this.button__addc.Location = new System.Drawing.Point(782, 544);
            this.button__addc.Name = "button__addc";
            this.button__addc.Size = new System.Drawing.Size(140, 47);
            this.button__addc.TabIndex = 38;
            this.button__addc.Text = "Add";
            this.button__addc.UseVisualStyleBackColor = false;
            this.button__addc.Click += new System.EventHandler(this.button__addc_Click);
            // 
            // button_clearc
            // 
            this.button_clearc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clearc.BackColor = System.Drawing.Color.Sienna;
            this.button_clearc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_clearc.ForeColor = System.Drawing.Color.White;
            this.button_clearc.Location = new System.Drawing.Point(620, 544);
            this.button_clearc.Name = "button_clearc";
            this.button_clearc.Size = new System.Drawing.Size(156, 47);
            this.button_clearc.TabIndex = 37;
            this.button_clearc.Text = "Clear";
            this.button_clearc.UseVisualStyleBackColor = false;
            this.button_clearc.Click += new System.EventHandler(this.button_clearc_Click);
            // 
            // textBox_curs
            // 
            this.textBox_curs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_curs.Location = new System.Drawing.Point(208, 476);
            this.textBox_curs.Name = "textBox_curs";
            this.textBox_curs.Size = new System.Drawing.Size(207, 27);
            this.textBox_curs.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(83, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 28);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nume curs:";
            // 
            // textBox_credit
            // 
            this.textBox_credit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_credit.Location = new System.Drawing.Point(208, 531);
            this.textBox_credit.Name = "textBox_credit";
            this.textBox_credit.Size = new System.Drawing.Size(207, 27);
            this.textBox_credit.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(83, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nr credite:";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.textBox_credit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_curs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button__addc);
            this.Controls.Add(this.button_clearc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView_course);
            this.Controls.Add(this.panel1);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_course)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_course;
        private System.Windows.Forms.Button button__addc;
        private System.Windows.Forms.Button button_clearc;
        private System.Windows.Forms.TextBox textBox_curs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_credit;
        private System.Windows.Forms.Label label2;
    }
}