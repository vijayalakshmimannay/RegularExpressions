using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    internal class RegExpression
    {
        const string FIRSTNAME = "^[A-Z]{1}[a-z]{2,}$";
        const string LASTNAME = "^[A-Z]{1}[a-z]{2,}$";
        const string EMAIL = "^(abc).?[a-z]{3,}[@](bl).?(co).?[a-z]{2,}$";
        const string CONTACT = "^[0-9]{1,3}[ ][789][0-9]{9}$";
        const string PASSWORD = "^[a-z A-Z 0-9]{1,}[A-Z]{1,}[a-z A-Z 0-9]{1,}[!*@#$%^&+=]?[a-z A-Z 0-9]{1,}[0-9]{1,}[a-z A-Z 0-9]{1,}$";
        const string SAMPLE = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public void RegexFirstNameChecker(string firstName)
        {
            if (Regex.IsMatch(firstName, FIRSTNAME))
            {
                Console.WriteLine("First name is valid.");
                return;
            }
            Console.WriteLine("First name is not valid.");
        }
        public void RegexLastNameChecker(string secondName)
        {
            if (Regex.IsMatch(secondName, LASTNAME))
            {
                Console.WriteLine("second name is valid.");
                return;
            }
            Console.WriteLine("second name is not valid.");
        }
        public void RegexEmail(string email)
        {
            if (Regex.IsMatch(email, EMAIL))
            {
                Console.WriteLine("E-Mail id is valid.");
                return;
            }
            Console.WriteLine("E-Mail id is not valid.");
        }
        public void RegexMobileNumber(string mobile)
        {
            if (Regex.IsMatch(mobile, CONTACT))
            {
                Console.WriteLine("Mobile number is valid.");
                return;
            }
            Console.WriteLine("Mobile number is not valid.");
        }
        public void RegexPassword(string password)
        {
            if (Regex.IsMatch(password, PASSWORD))
            {
                Console.WriteLine("Password is valid.");
                return;
            }
            Console.WriteLine("Password is not valid.");
        }
        public string RegexSampleMail(string sample)
        {
            if (Regex.IsMatch(sample, SAMPLE))
            {
                return "Valid";
            }
            return "Not Valid";
        }
    }
}
   
