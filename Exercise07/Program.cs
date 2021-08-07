using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManagement;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            //get JSON

            Console.WriteLine(DataManager.GetJSON());

            //Get XML

            Console.WriteLine(DataManager.GetXML());

            Console.ReadLine();
        }
    }
}
