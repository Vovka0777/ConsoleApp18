using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp18
{
    internal class Address
    {
        public int Index=4367;
        public string Country="Paris";
        public string City="London";
        public int House=54;
        public int Apartament=2;
        public void Print()
        {
            Console.WriteLine($"Индекс: {Index}\nСтрана:{Country}\nГород: {City}\nДом: {House}\nКвартира: {Apartament}");
        }
    }
}
