
namespace Student_Management_System
{
    partial class ScoreForm
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
            this.textBox_studId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button__add = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_score = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_student = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_course = new System.Windows.Forms.ComboBox();
            this.dataGridView_score = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_score)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(321, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "CATALOG DE NOTE";
            // 
            // textBox_studId
            // 
            this.textBox_studId.Location = new System.Drawing.Point(141, 393);
            this.textBox_studId.Name = "textBox_studId";
            this.textBox_studId.Size = new System.Drawing.Size(127, 27);
            this.textBox_studId.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(29, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 28);
            this.label5.TabIndex = 50;
            this.label5.Text = "Student Id:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(0, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 16);
            this.panel2.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 81);
            this.panel1.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(715, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Note";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(108, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lista de studenti";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(437, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(29, 315);
            this.panel3.TabIndex = 0;
            // 
            // button__add
            // 
            this.button__add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button__add.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button__add.ForeColor = System.Drawing.Color.White;
            this.button__add.Location = new System.Drawing.Point(780, 553);
            this.button__add.Name = "button__add";
            this.button__add.Size = new System.Drawing.Size(140, 47);
            this.button__add.TabIndex = 47;
            this.button__add.Text = "Add";
            this.button__add.UseVisualStyleBackColor = false;
            this.button__add.Click += new System.EventHandler(this.button__add_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.OrangeRed;
            this.button_clear.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(618, 553);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(156, 47);
            this.button_clear.TabIndex = 46;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox_score
            // 
            this.textBox_score.Location = new System.Drawing.Point(141, 482);
            this.textBox_score.Name = "textBox_score";
            this.textBox_score.Size = new System.Drawing.Size(127, 27);
            this.textBox_score.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(71, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nota:";
            // 
            // dataGridView_student
            // 
            this.dataGridView_student.AllowUserToAddRows = false;
            this.dataGridView_student.AllowUserToDeleteRows = false;
            this.dataGridView_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_student.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_student.ColumnHeadersHeight = 24;
            this.dataGridView_student.Location = new System.Drawing.Point(3, 78);
            this.dataGridView_student.Name = "dataGridView_student";
            this.dataGridView_student.RowHeadersWidth = 30;
            this.dataGridView_student.RowTemplate.Height = 80;
            this.dataGridView_student.Size = new System.Drawing.Size(463, 278);
            this.dataGridView_student.TabIndex = 21;
            this.dataGridView_student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_student_CellClick);
            this.dataGridView_student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_student_CellContentClick);
            this.dataGridView_student.Click += new System.EventHandler(this.dataGridView_student_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(19, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 41;
            this.label1.Text = "Alege curs:";
            // 
            // comboBox_course
            // 
            this.comboBox_course.FormattingEnabled = true;
            this.comboBox_course.Location = new System.Drawing.Point(141, 439);
            this.comboBox_course.Name = "comboBox_course";
            this.comboBox_course.Size = new System.Drawing.Size(319, 28);
            this.comboBox_course.TabIndex = 52;
            // 
            // dataGridView_score
            // 
            this.dataGridView_score.AllowUserToAddRows = false;
            this.dataGridView_score.AllowUserToDeleteRows = false;
            this.dataGridView_score.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_score.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_score.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_score.ColumnHeadersHeight = 24;
            this.dataGridView_score.Location = new System.Drawing.Point(483, 78);
            this.dataGridView_score.Name = "dataGridView_score";
            this.dataGridView_score.RowHeadersWidth = 65;
            this.dataGridView_score.RowTemplate.Height = 80;
            this.dataGridView_score.Size = new System.Drawing.Size(449, 278);
            this.dataGridView_score.TabIndex = 53;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Location = new System.Drawing.Point(466, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 315);
            this.panel4.TabIndex = 54;
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView_score);
            this.Controls.Add(this.comboBox_course);
            this.Controls.Add(this.textBox_studId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button__add);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.textBox_score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_student);
            this.Controls.Add(this.label1);
            this.Name = "ScoreForm";
            this.Text = "ScoreForm";
            this.Load += new System.EventHandler(this.ScoreForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_studId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button__add;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_student;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_course;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView_score;
        private System.Windows.Forms.Panel panel4;
    }
}