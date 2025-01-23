using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    /// <summary>
    /// Класс Личность
    /// </summary>
    internal class Person
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name;
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname;
        /// <summary>
        /// Возраст
        /// </summary>
        public int Age;
        /// <summary>
        /// Метод вывода значений в консоль
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Имя:{Name}\nФамилия:{Surname}\nВозраст:{Age}");
        }
    }
}
