using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
            Console.WriteLine("Enter your Email ID");
            string EmailAddres=Console.ReadLine();
           

            if (IsValidFirstName(EmailAddres))
            {
                Console.WriteLine("Valid EmailAddress!");

            }
            else
            {
                Console.WriteLine("Invalid  EmailAddress!");
            }

           
        }
        static bool IsValidFirstName(string EmailAddress)
        {
            string pattern = @"^[a-zA-Z0-9]+(?:\.[a-zA-Z0-9]+)*@[a-zA-Z0-9]+(?:\.[a-zA-Z0-9]+)*\.(?:[a-zA-Z]{2,})$";

            return Regex.IsMatch(EmailAddress, pattern);
        }

      
    }
}
