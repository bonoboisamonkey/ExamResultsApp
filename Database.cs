using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsForm
{
    static class Database
    {
        private static List<Lesson> _lessons;
        private static List<Student> _students;
        private static List<Exam> _exams;

        static Database()
        {
            _lessons = new List<Lesson>();
            _students = new List<Student>();
            _exams = new List<Exam>();
        }

        internal static void Add(Lesson lesson)
        {
            _lessons.Add(lesson);
        }

        internal static List<Lesson> GetAllLessons()
        {
            return _lessons;
        }
        internal static void Add(Student student)
        {
            _students.Add(student);
        }
        internal static List<Student> GetAllStudents()
        {
            return _students;
        }
        internal static void Add(Exam exam)
        {
            _exams.Add(exam);
        }
        internal static List<Exam> GetAllExams()
        {
            return _exams;
        }

        internal static string GetAllExams(int lesson_id, int student_id)
        {
            string result = String.Empty;
            foreach(Lesson item in _lessons)
            {
               if(item.Lesson_ID== lesson_id)
                {
                    result += item.Lesson_Name + " ";
                }
            }

            foreach (Student item in _students)
            {
                if (item.Student_ID == student_id)
                {
                    result += item.Student_Name + " ";
                }
            }

            return result;
        }

    }
}
