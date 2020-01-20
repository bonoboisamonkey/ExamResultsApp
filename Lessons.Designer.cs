namespace LessonsForm
{
    partial class lesson_form
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
            this.txbx_surname = new System.Windows.Forms.TextBox();
            this.txbx_name = new System.Windows.Forms.TextBox();
            this.txbx_class = new System.Windows.Forms.TextBox();
            this.txbx_lesson = new System.Windows.Forms.TextBox();
            this.txbx_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lable4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbx_surname);
            this.groupBox1.Controls.Add(this.txbx_name);
            this.groupBox1.Controls.Add(this.txbx_class);
            this.groupBox1.Controls.Add(this.txbx_lesson);
            this.groupBox1.Controls.Add(this.txbx_ID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lable4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(48, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lesson";
            // 
            // txbx_surname
            // 
            this.txbx_surname.Location = new System.Drawing.Point(137, 123);
            this.txbx_surname.Name = "txbx_surname";
            this.txbx_surname.Size = new System.Drawing.Size(100, 20);
            this.txbx_surname.TabIndex = 1;
            // 
            // txbx_name
            // 
            this.txbx_name.Location = new System.Drawing.Point(137, 97);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(100, 20);
            this.txbx_name.TabIndex = 1;
            // 
            // txbx_class
            // 
            this.txbx_class.Location = new System.Drawing.Point(137, 71);
            this.txbx_class.Name = "txbx_class";
            this.txbx_class.Size = new System.Drawing.Size(100, 20);
            this.txbx_class.TabIndex = 1;
            // 
            // txbx_lesson
            // 
            this.txbx_lesson.Location = new System.Drawing.Point(137, 45);
            this.txbx_lesson.Name = "txbx_lesson";
            this.txbx_lesson.Size = new System.Drawing.Size(100, 20);
            this.txbx_lesson.TabIndex = 1;
            // 
            // txbx_ID
            // 
            this.txbx_ID.Location = new System.Drawing.Point(137, 19);
            this.txbx_ID.Name = "txbx_ID";
            this.txbx_ID.Size = new System.Drawing.Size(100, 20);
            this.txbx_ID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Teacher`s surname";
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.Location = new System.Drawing.Point(6, 101);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(84, 13);
            this.lable4.TabIndex = 0;
            this.lable4.Text = "Teacher`s name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lesson Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lesson ID";
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(57, 258);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 1;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.Btn_register_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(210, 258);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.Btn_next_Click);
            // 
            // lesson_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 370);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "lesson_form";
            this.Text = "Lessons";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbx_surname;
        private System.Windows.Forms.TextBox txbx_name;
        private System.Windows.Forms.TextBox txbx_class;
        private System.Windows.Forms.TextBox txbx_lesson;
        private System.Windows.Forms.TextBox txbx_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lable4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_next;
    }
}

