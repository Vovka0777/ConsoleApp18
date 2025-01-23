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
            //создание объекта класса Person
            Person person = new Person();
            //устанавливаем новые значения полей
            person.Name = "Наталья";
            person.Surname = "Шандригоз";
            person.Age = 18;
            //обращаемся к методу Print
            person.Print();
        }
    }
}
