using System;

namespace LoginApp
{
    class Program
    {
       
        public string userinput = "";
        
        static void Main(string[] args)
        {
            // Executable Title
            Console.Title = "LoginApp";

            // Sign Up or Sign In
            Console.Write("Type /sup to sign up or type /sin to sign in: ");
            string userinput = Console.ReadLine();

            // Check option
            if (userinput == "/sup")
            {
                Login.SignUp();
            }
            else if (userinput == "/sin")
            {
                Login.SignIn();
            }
            else
            {
                return;
            }
            
            // Wait for user Input before closing
            Console.ReadKey();
        }
    }

    class Login
    {
        public static void SignUp()
        {

        }

        public static void SignIn()
        {

        }
    }
}
