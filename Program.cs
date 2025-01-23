using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Наталья";
            person.Surname = "Шандригоз";
            person.Age = 18;
            person.Print();
        }
    }
}
