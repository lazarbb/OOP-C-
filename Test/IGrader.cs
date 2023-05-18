using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    interface IGrader
    {
        public List<bool> CreateListOfStudentsPassed(List<Student> students);
        public double CalculateAverageScore(List<Student> students);
    }
}
