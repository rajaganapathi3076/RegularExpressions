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
            Console.WriteLine("Welcome User registration UC8");
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
        static bool IsValidPassWord(string password)     //Rule 3 : Password is Minimum 8 Character, 2.should one upper case,3.should have one numeric number,4.should one special character
        {
            string pattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*\W).{8,}$";

            return Regex.IsMatch(password, pattern);
        }

      
    }
}
