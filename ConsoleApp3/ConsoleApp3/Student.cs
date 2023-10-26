using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Student
    {
        private string _studentName; // Made this a string for the student's name
        public string Grade { get; set; }

        public Student(string studentName, string grade)
        {
            _studentName = studentName;
            Grade = grade;
        }

        public string Greeting()
        {
            return $"Hi, I'm {_studentName} and I'm in grade {Grade}.";
        }
    }
}
