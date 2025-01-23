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
            Address address = new Address();
            int Index = address.Index;
            string Country = address.Country;
            string City = address.City;
            int House = address.House;
            int Apartament = address.Apartament;
            Console.WriteLine($"Индекс: {Index}\nСтрана:{Country}\nГород: {City}\nДом: {House}\nКвартира: {Apartament}\n\n");

            address.Index = 5932;
            address.Country = "Russia";
            address.City = "Moscow";
            address.House = 23;
            address.Apartament = 8;
            address.Print();
        }
    }
}
