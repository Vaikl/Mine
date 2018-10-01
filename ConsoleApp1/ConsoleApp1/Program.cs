using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   class Program
    {
        static void Main(string[] args)
        {
           // ConsoleApp q = new ConsoleApp();
           
            
        }
        
    }
    public class ConsoleApp
    {
       public bool triangle(int a, int b, int c)
        {
           // int a, b, c;
          /*  a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());*/
            if (a + b > c && a + c > b && b + c > a) { return true; } else { return false; }
        }
    }
}
