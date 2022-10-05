using System.Net.Http.Headers;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Validate validate = new Validate();
            validate.Email("abc");
            validate.Email("abc@bridgelabz");
            validate.Email("abc@bridgelabz.co");
            validate.Email("abc@xyzbridgelabz.com.in");
            validate.Email("abc@bridgelabz.in");
        }
    }
}