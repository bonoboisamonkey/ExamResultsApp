using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LessonsForm
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void Btn_register_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Student_ID = int.Parse(txbx_student_id.Text);
            student.Student_Name = txbx_student_name.Text;
            student.Student_SurName = txbx_student_surname.Text;
            student.Student_Class = txbx_class_name.Text;

            Database.Add(student);
        }

        private void Btn_next_Click(object sender, EventArgs e)
        {
            Exams examForm = new Exams();
            examForm.Show();
        }
    }
}
