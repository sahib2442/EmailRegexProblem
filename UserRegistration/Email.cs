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
    }
}
