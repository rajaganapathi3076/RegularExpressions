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
            Console.WriteLine("Welcome User registration UC4");
            Console.WriteLine("Enter your Mobile Number");
            string mobilenumber=Console.ReadLine();
           

            if (IsValidMobileNumber(mobilenumber))
            {
                Console.WriteLine("Valid MobileNumber!");

            }
            else
            {
                Console.WriteLine("Invalid  MobileNumber!");
            }

           
        }
        static bool IsValidMobileNumber(string mobilenumber)
        {
            string pattern = @"^91 [6-9]{1}[0-9]{9}$";

            return Regex.IsMatch(mobilenumber, pattern);
        }

      
    }
}
