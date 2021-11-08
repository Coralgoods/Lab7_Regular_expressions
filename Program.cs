using System;
using System.Text.RegularExpressions;

namespace LAB7RegExpressions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string userInput;


            //Valdiate Name 
            Console.WriteLine("Please enter a valid name:");
            userInput = Console.ReadLine();

            string consoleReturnMessage = ValidateName(userInput);

            Console.WriteLine(consoleReturnMessage);
            Console.WriteLine(" ");


            //Valdiate email
            Console.WriteLine("Please enter a valid email:");
            userInput = Console.ReadLine();

            consoleReturnMessage = ValidateEmail(userInput);

            Console.WriteLine(consoleReturnMessage);
            Console.WriteLine(" ");

            //Valdiate phone number
            Console.WriteLine("Please enter a valid phone number:");
            userInput = Console.ReadLine();

            consoleReturnMessage = ValidatePhoneNumber(userInput);
            Console.WriteLine(consoleReturnMessage);


            //Valdiate date
            Console.WriteLine("Please enter a valid date:");
            userInput = Console.ReadLine();

            consoleReturnMessage = ValidateDate(userInput);
            Console.WriteLine(consoleReturnMessage);


            //Valdiate HTML
            Console.WriteLine("Please enter a valid HTML:");
            userInput = Console.ReadLine();

            consoleReturnMessage = ValidateHTML(userInput);
            Console.WriteLine(consoleReturnMessage);

        }

        public static string ValidateName(string name)
        {
            string message;
            string namePattern = @"^[A-Z]{1}[a-zA-Z]{1,29}$";

            Regex regex = new Regex(namePattern);

            bool isMatch = regex.IsMatch(name);

            if (isMatch == false)
            {
                message = "Sorry, name is not valid!";
            }
            else
            {
                message = "Name is Valid!";

            }

            return message; 
        }
        public static string ValidateEmail(string email)
        {
            string message;
            string namePattern = @"^[a-zA-Z]{5,30}@[a-zA-Z]{5,10}.[a-zA-Z]{2,3}$";

            Regex regex = new Regex(namePattern);

            bool isMatch = regex.IsMatch(email);

            if (isMatch == false)
            {
                message = "Sorry, Email is not valid!";
            }
            else
            {
                message = "Email is Valid!";
            }

            return message;
        }
        public static string ValidatePhoneNumber(string phoneNumber)
        {
            string message;
            string namePattern = @"^[1-9]{3}-[1-9]{3}-[1-9]{4}$";

            Regex regex = new Regex(namePattern);

            bool isMatch = regex.IsMatch(phoneNumber);

            if (isMatch == false)
            {
                message = "Sorry, phone number is not valid!";
            }
            else
            {
                message = "Phone number is Valid!";
            }

            return message;
        }
        public static string ValidateDate(string date)
        {
            string message;
            string namePattern = @"^[1-3]{1}[1-9]{1}\/[0-1]{1}[1-9]{1}\/[1-9]{4}";

            Regex regex = new Regex(namePattern);

            bool isMatch = regex.IsMatch(date);

            if (isMatch == false)
            {
                message = "Sorry, date is not valid!";
            }
            else
            {
                message = "Date is Valid!";
            }

            return message;
        }
        public static string ValidateHTML(string html)
        {
            string message;
            string namePattern = @"^<[a-zA-Z1-9]>[a-zA-Z1-9 ]*<\/[a-zA-Z1-9]>$";

            Regex regex = new Regex(namePattern);

            bool isMatch = regex.IsMatch(html);

            if (isMatch == false)
            {
                message = "Sorry, HTML is not valid!";
            }
            else
            {
                message = "HTML is Valid!";
            }

            return message;

        }


    }
}
