namespace LessonsForm
{
    partial class Exams
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_points = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_date = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.cmbx_lesson_id = new System.Windows.Forms.ComboBox();
            this.cmbx_student_id = new System.Windows.Forms.ComboBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbx_student_id);
            this.groupBox1.Controls.Add(this.cmbx_lesson_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbx_points);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbx_date);
            this.groupBox1.Location = new System.Drawing.Point(25, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exams";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lesson ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student ID";
            // 
            // txbx_points
            // 
            this.txbx_points.Location = new System.Drawing.Point(140, 137);
            this.txbx_points.Name = "txbx_points";
            this.txbx_points.Size = new System.Drawing.Size(121, 20);
            this.txbx_points.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Points";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Exam Date";
            // 
            // txbx_date
            // 
            this.txbx_date.Location = new System.Drawing.Point(140, 111);
            this.txbx_date.Name = "txbx_date";
            this.txbx_date.Size = new System.Drawing.Size(121, 20);
            this.txbx_date.TabIndex = 9;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(60, 276);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.Btn_register_Click);
            // 
            // cmbx_lesson_id
            // 
            this.cmbx_lesson_id.FormattingEnabled = true;
            this.cmbx_lesson_id.Location = new System.Drawing.Point(140, 50);
            this.cmbx_lesson_id.Name = "cmbx_lesson_id";
            this.cmbx_lesson_id.Size = new System.Drawing.Size(121, 21);
            this.cmbx_lesson_id.TabIndex = 10;
            // 
            // cmbx_student_id
            // 
            this.cmbx_student_id.FormattingEnabled = true;
            this.cmbx_student_id.Location = new System.Drawing.Point(141, 82);
            this.cmbx_student_id.Name = "cmbx_student_id";
            this.cmbx_student_id.Size = new System.Drawing.Size(121, 21);
            this.cmbx_student_id.TabIndex = 10;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(190, 276);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.Btn_next_Click);
            // 
            // Exams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 343);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Exams";
            this.Text = "Exams";
            this.Load += new System.EventHandler(this.Exams_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_points;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbx_date;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.ComboBox cmbx_student_id;
        private System.Windows.Forms.ComboBox cmbx_lesson_id;
        private System.Windows.Forms.Button btn_next;
    }
}