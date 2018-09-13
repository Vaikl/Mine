using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Student
    {
        public List<int> marks = new List<int>();
        public string names;
        public Student(string names, List<int> marks) { this.names = names; this.marks = marks; }
        public string GetNames()
        {
            return names;
        }

        public float GetMarks()
        {
            return (float)marks.Average();
        }
    }
}
