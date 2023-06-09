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
            Console.WriteLine("Enter your first name");
            string firstname=Console.ReadLine();

            if(IsValidFirstName(firstname))
            {
                Console.WriteLine("Valid first name!");

            }
            else
            {
                Console.WriteLine("Invalid first name");
            }
        }
        static bool IsValidFirstName(string firstName)
        {
            string pattern = "^[A-Z][a -zA-Z]{2,}$";

            return Regex.IsMatch(firstName, pattern);
        }

      
    }
}
