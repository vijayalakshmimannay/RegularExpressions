// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using RegularExpression;
using System;
namespace RegEx

{
    class program
    {
        public static void Main(string[] args)
        {
            RegExpression regex = new RegExpression();

            Console.WriteLine("Enter Name to check:");
            Console.Write("First Name:");
            string firstName = Console.ReadLine();
            Console.Write("Last Name:");
            string lastName = Console.ReadLine();
            Console.Write("EMAIL:");
            string email = Console.ReadLine();
            Console.Write("CONTACT:");
            string mobileNumber = Console.ReadLine();
            Console.Write("PASSWORD:");
            string password = Console.ReadLine();
            regex.RegexFirstNameChecker(firstName);
            regex.RegexLastNameChecker(lastName);
            regex.RegexEmail(email);
            regex.RegexMobileNumber(mobileNumber);
            regex.RegexPassword(password);
            Console.WriteLine("\nSample emails validation:\n");
            string[] sample = File.ReadAllLines(@"C:\BridgeLabz\.Net_Fellowship\REGEX\RegularExpression\SampleMails.txt");
            for (int i = 0; i < sample.Length; i++)
            {
                string ret = regex.RegexSampleMail(sample[i]);
                Console.WriteLine(sample[i] + "  --  " + ret);
            }
        }
    }
}
    
