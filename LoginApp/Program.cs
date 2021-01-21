using System;

namespace LoginApp
{
    class Program
    {
       
        public string userinput;
        
        static void Main(string[] args)
        {
            // Executable Title
            Console.Title = "LoginApp";

            // Sign Up or Sign In
            Console.Write("Type /sup to sign up or type /sin to sign in: ");

            // Wait for user Input before closing
            Console.ReadKey();
        }
    }

    class Login
    {
        static void SignUp()
        {

        }

        static void SignIn()
        {

        }
    }
}
