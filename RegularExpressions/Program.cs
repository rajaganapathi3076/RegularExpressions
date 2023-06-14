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
            Console.WriteLine("Welcome User registration UC6");
            Console.Write("Enter your Password: ");
            string password=Console.ReadLine();
           

            if (IsValidPassWord(password))
            {
                Console.WriteLine("Valid Password!");

            }
            else
            {
                Console.WriteLine("Invalid  Password!");
            }

           
        }
        static bool IsValidPassWord(string password)     //Rule 2 : Password is Minimum 8 Character and should one upper case//
        {
            string pattern = @"^(?=.*[A-Z])[a-zA-Z0-9]{8}$";

            return Regex.IsMatch(password, pattern);
        }

      
    }
}
