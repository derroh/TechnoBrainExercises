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
            do
            {
                Console.WriteLine("Enter a number: ");
                string number = Console.ReadLine();

                number = number.Replace(",", "");

                int value;
                if (int.TryParse(number, out value))
                {
                    //output message
                    Console.Write(Exercise02.Towards(number));
                    break;
                }
                else
                {
                    Console.WriteLine("Your input does't match the accepted values ");
                }                 

            } while (true);

            Console.ReadKey();
        }
    }
}
