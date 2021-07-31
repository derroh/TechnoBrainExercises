using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise03
{
    using Exercise02; //using our class library
    class Program
    {
        static void Main(string[] args)
        {
            string number = null;
            Console.WriteLine("Enter a number: ");
            number = Console.ReadLine();
            
            //get rid of commas before passing to our class library
            number = number.Replace(",", "");
            //output message
            Console.Write(Exercise02.Towards(number));

            Console.ReadKey();
        }
    }
}
