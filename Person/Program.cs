using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Person.Clasess;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            People Om1 = new People("Robert");
            People Om2 = new People("Andrei", 47);
            Console.WriteLine(Om1);
            Console.WriteLine(Om2);
        }
    }
}
