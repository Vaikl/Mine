using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student q = new Student("qwe", new List<int>(){1, 2, 3, 4, 5});
            Student w = new Student("ewq", new List<int>() {5, 6, 7, 8, 9 });
            Student e = new Student("asd", new List<int>() {5, 6, 6, 7, 8 });
            List<Student> MarkStudents = new List<Student>() { q, w, e };
            Group zero = new Group("zero", MarkStudents);
            List<Group> groups = new List<Group>() { zero};
            int a=Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1: Console.WriteLine("Введите имя студента");
                    String name = Console.ReadLine();
                    foreach (Student i in MarkStudents) {
                        if (i.GetNames() == name)
                        {
                            Console.WriteLine(i.GetNames() + i.GetMarks());
                        }
                    }
                    break;
                case 2: Console.WriteLine("Введите номер группы");
                    string number = Console.ReadLine();
                    foreach(Group l in groups)
                    {
                        if (l.GetNumber() == number) { Console.WriteLine(l.GetNumber() + ' ' +l.GetStudentsMarks()); }
                    }
                        break;
            }
            Console.ReadKey();
        }
    }
}
