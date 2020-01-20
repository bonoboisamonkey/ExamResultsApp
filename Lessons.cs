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
    public partial class lesson_form : Form
    {
        public lesson_form()
        {
            InitializeComponent();
        }

        private void Btn_register_Click(object sender, EventArgs e)
        {
            Lesson lesson = new Lesson();
            lesson.Lesson_ID = int.Parse(txbx_ID.Text);
            lesson.Lesson_Name = txbx_name.Text;
            lesson.Class_Name = txbx_class.Text;
            lesson.Teacher_Name = txbx_name.Text;
            lesson.Teacher_SurName = txbx_surname.Text;

            Database.Add(lesson);
        }

        private void Btn_next_Click(object sender, EventArgs e)
        {
            Students studentForm = new Students();
            studentForm.Show();
        }
    }
}
