
namespace Student_Management_System
{
    partial class PrintStudent
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
            this.dataGridView_student = new System.Windows.Forms.DataGridView();
            this.button__printstd = new System.Windows.Forms.Button();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_all = new System.Windows.Forms.RadioButton();
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 42);
            this.panel1.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(321, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "PRINT STUDENTS";
            // 
            // dataGridView_student
            // 
            this.dataGridView_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_student.Location = new System.Drawing.Point(0, 85);
            this.dataGridView_student.Name = "dataGridView_student";
            this.dataGridView_student.RowHeadersWidth = 51;
            this.dataGridView_student.RowTemplate.Height = 29;
            this.dataGridView_student.Size = new System.Drawing.Size(882, 426);
            this.dataGridView_student.TabIndex = 35;
            // 
            // button__printstd
            // 
            this.button__printstd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button__printstd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button__printstd.ForeColor = System.Drawing.Color.White;
            this.button__printstd.Location = new System.Drawing.Point(730, 544);
            this.button__printstd.Name = "button__printstd";
            this.button__printstd.Size = new System.Drawing.Size(140, 47);
            this.button__printstd.TabIndex = 36;
            this.button__printstd.Text = "Print";
            this.button__printstd.UseVisualStyleBackColor = false;
            this.button__printstd.Click += new System.EventHandler(this.button__printstd_Click);
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton_male.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton_male.Location = new System.Drawing.Point(275, 540);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(113, 32);
            this.radioButton_male.TabIndex = 39;
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
            this.radioButton_female.Location = new System.Drawing.Point(142, 540);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(106, 32);
            this.radioButton_female.TabIndex = 38;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Feminin";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(65, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 28);
            this.label4.TabIndex = 37;
            this.label4.Text = "Sex:";
            // 
            // radioButton_all
            // 
            this.radioButton_all.AutoSize = true;
            this.radioButton_all.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton_all.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton_all.Location = new System.Drawing.Point(394, 542);
            this.radioButton_all.Name = "radioButton_all";
            this.radioButton_all.Size = new System.Drawing.Size(56, 32);
            this.radioButton_all.TabIndex = 40;
            this.radioButton_all.TabStop = true;
            this.radioButton_all.Text = "All";
            this.radioButton_all.UseVisualStyleBackColor = true;
            // 
            // comboBox_class
            // 
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Location = new System.Drawing.Point(590, 48);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(145, 28);
            this.comboBox_class.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(510, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 28);
            this.label5.TabIndex = 42;
            this.label5.Text = "Grupa:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(741, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 35);
            this.button1.TabIndex = 43;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrintStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_class);
            this.Controls.Add(this.radioButton_all);
            this.Controls.Add(this.radioButton_male);
            this.Controls.Add(this.radioButton_female);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button__printstd);
            this.Controls.Add(this.dataGridView_student);
            this.Controls.Add(this.panel1);
            this.Name = "PrintStudent";
            this.Text = "PrintStudent";
            this.Load += new System.EventHandler(this.PrintStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_student;
        private System.Windows.Forms.Button button__printstd;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_all;
        private System.Windows.Forms.ComboBox comboBox_class;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}