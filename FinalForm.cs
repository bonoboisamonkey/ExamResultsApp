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
    public partial class FinalForm : Form
    {
        public FinalForm()
        {
            InitializeComponent();
        }

        private void FinalForm_Load(object sender, EventArgs e)
        {
            List<Exam> Exams = Database.GetAllExams();


            foreach(Exam item in Exams)
            {
                string result = "";
                result +=Database.GetAllExams(item.Lesson_ID, item.Student_ID) + item.Exam_Date + " " + item.Exam_Point;
                list_exams.Items.Add(result);
            }

        }
    }
}
