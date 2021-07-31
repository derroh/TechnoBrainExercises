using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            string regEx = "^[a-z]+$", userRegex = null, userInput = "";

            Console.WriteLine("The default regular expression checks for at least one digit.");

            do
            {
                Console.WriteLine("Enter a regular expression (or press ENTER to use the default): ^[a-z]+$");
                userRegex = Console.ReadLine();

                Console.WriteLine("Enter some input:");
                userInput = Console.ReadLine();

                if (!string.IsNullOrEmpty(userRegex))
                    regEx = userRegex;

                if (RegexFunctions.IsValidInput(userInput, regEx))
                {
                    Console.WriteLine("{0} matches {1}? {2}", userInput, regEx, true);
                   // break; until user esc
                }
                else
                {
                    Console.WriteLine("{0} matches {1}? {2}", userInput, regEx, false);
                }
                    

            } while (true);

            Console.ReadKey();
        }
       
    }
    static class RegexFunctions
    {
        /// <summary>
        /// Function checks user inout against specified regex
        /// </summary>
        /// <param name="s"></param>
        /// <param name="user_regex"></param>
        /// <returns></returns>
        public static bool IsValidInput(this string s, string user_regex)
        {
            Regex regex = new Regex(user_regex);
            return regex.IsMatch(s);
        }
    }
}
