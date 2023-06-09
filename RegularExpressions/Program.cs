using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome User registration UC2");
            Console.WriteLine("Enter your first name");
            string firstname=Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lastname = Console.ReadLine();

            if (IsValidFirstName(firstname))
            {
                Console.WriteLine("Valid first name!");

            }
            else
            {
                Console.WriteLine("Invalid first name");
            }

            if (IsValidFirstName(lastname))
            {
                Console.WriteLine("Valid last name!");

            }
            else
            {
                Console.WriteLine("Invalid last name");
            }
        }
        static bool IsValidFirstName(string firstName)
        {
            string pattern = "^[A-Z][a -zA-Z]{2,}$";

            return Regex.IsMatch(firstName, pattern);
        }

      
    }
}
