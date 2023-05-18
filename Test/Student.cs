using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Student : IGrader
    {
        public double ExamPercent { get; private set; }
        public double AttendancePercent { get; private set; }

        public Student(double examPercent, double attendancePercent)
        {
             if (examPercent > 1.0 || attendancePercent > 1.0) throw new ArgumentOutOfRangeException();
             if (examPercent < 0.0 || attendancePercent < 0.0) throw new ArgumentOutOfRangeException();
             ExamPercent = examPercent; AttendancePercent = attendancePercent;
        }

        public List<bool> CreateListOfStudentsPassed(List<Student> students)
        {
            List<bool> examResults = new List<bool>();
            for(int i = 0; i < students.Count; i++)
            {
                if (students[i].ExamPercent >= 50)
                {
                    examResults[i] = true;
                }
                else examResults[i] = false;
            }
            return examResults;
        }

        public double CalculateAverageScore(List<Student> students)
        {
            ;
        }
    }
}
