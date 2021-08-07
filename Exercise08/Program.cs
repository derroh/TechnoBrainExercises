using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManagement;

namespace Exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataManager.GetDistinctCityList());
            Console.WriteLine(" ");

            Console.WriteLine("Enter the name of a city: ");
            string cityName = Console.ReadLine();

            var customerList = DataManager.GetCustomerList(cityName);

            Console.WriteLine($"There are {customerList.Count()} customers in {cityName}");

            foreach(var customer in customerList)
            {
                Console.WriteLine(customer.ContactName);
            }

            Console.ReadLine();
        }
    }
}
