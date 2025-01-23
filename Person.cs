using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public void Print()
        {
            Console.WriteLine($"Имя:{Name}\nФамилия:{Surname}\nВозраст:{Age}");
        }
    }
}
