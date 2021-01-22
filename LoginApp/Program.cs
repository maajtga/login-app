using System;
using System.IO;

namespace LoginApp
{
    class Program
    {
       
        public string userinput = "";
        
        public static void Main()
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
            // Ask for new Username and Password
            Console.Write("Enter a new Username: ");
            string userName = Console.ReadLine();
            Console.Write("Please Enter Your new Password: ");
            string passWord = Console.ReadLine();
            Console.Write("Please Renter your Password: ");
            string userinput = Console.ReadLine();
            
            // Check if password matches up correctly
            if (passWord == userinput)      
            {
            
            // Create New Login File as .txt  
            StreamWriter sw = new StreamWriter("loginfile/logincredentials.txt");

            // Write to the file
            sw.WriteLine(userName);
            sw.WriteLine(passWord);
            sw.Close(); 
            
            //Thank for creating an account and move back to login
            Console.WriteLine("Thank you for signing up!");
            Program.Main();

            }
            else
            {
                Console.WriteLine("The two passwords do not match");
            }
        
        }

        public static void SignIn()
        {
            Console.WriteLine("Nothing yet...");
        }
    }
}