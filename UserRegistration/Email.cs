using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace UserRegistration
{
    public class Email
    {
        public const string FIRSTNAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,3}$";
        public void FirstName(string firstName)
        {
            Regex regex = new Regex(FIRSTNAME_REGEX);
            bool result = regex.IsMatch(firstName);
            Console.WriteLine("UC1: Enterd First Name is" + result);
        }
        public const string LASTNAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,3}$";
        public void LastName(string lastName)
        {
            Regex regex = new Regex(LASTNAME_REGEX);
            bool result = regex.IsMatch(lastName);
            Console.WriteLine("UC2: Enterd Last Name is" + result);
        }
        public const string EMAIL_REGEX = "^[A-Z]{1}[A-Za-z]{2,3}{0,1}$";
        public void Email(string email)
        {
            Regex regex = new Regex(EMAIL_REGEX);
            bool result = regex.IsMatch(email);
            Console.WriteLine("UC3: Enterd Email is" + result);
        }
        public const string PHONENUMBER_REGEX = "^[0-9a-zA-z]{0,1}[A-Z]{1}[A-Za-z]{2,3}{0,1}$";
        public void PhoneNumber(string phoneNumber)
        {
            Regex regex = new Regex(PHONENUMBER_REGEX);
            bool result = regex.IsMatch(phoneNumber);
            Console.WriteLine("UC4: Enterd Phone Number is" + result);
        }
    }
}
