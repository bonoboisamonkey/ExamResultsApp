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
    public partial class Exams : Form
    {
        public Exams()
        {
            InitializeComponent();
        }

        private void Btn_register_Click(object sender, EventArgs e)
        {
            Exam exam = new Exam();
            exam.Lesson_ID = int.Parse(cmbx_lesson_id.Text);
            exam.Student_ID = int.Parse(cmbx_student_id.Text);
            exam.Exam_Date = txbx_date.Text;
            exam.Exam_Point = double.Parse(txbx_points.Text);

            Database.Add(exam);
        }


        private void Exams_Load(object sender, EventArgs e)
        {
            List<Lesson> lessons = Database.GetAllLessons();
            List<Student> students = Database.GetAllStudents();

            foreach(Lesson item in lessons)
            {
                cmbx_lesson_id.Items.Add(item.Lesson_ID);
            }

            foreach (Student item in students)
            {
                cmbx_student_id.Items.Add(item.Student_ID);
            }
        }

        private void Btn_next_Click(object sender, EventArgs e)
        {
            FinalForm finalForm = new FinalForm();
            finalForm.Show();
        }
    }
}
