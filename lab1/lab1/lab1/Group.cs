using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Group
    {
        public List<Student> students = new List<Student>();
        public string number;
        public Group(string number, List<Student> students) { this.number = number; this.students = students; }
        public string GetNumber()
        {
            return number;
        }

        public float GetStudentsMarks()
        {
            return (float)students.Select(i=>i.GetMarks()).Average();
        }
    }
}
