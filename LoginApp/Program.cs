using System;
using System.IO;

namespace LoginApp
{
    class Program
    {
        // Simple userinput
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
                Console.WriteLine("Invalid command");
                Main();
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
            // Check if file loginfile exists
            if (File.Exists("loginfile/logincredentials.txt"))
            {
                StreamReader sr = new StreamReader("loginfile/logincredentials.txt");
                
                // Get username
                string username = sr.ReadLine();

                // Enter Username
                Console.Write("Enter your Username: ");
                string userinput = Console.ReadLine();

                // Check if it matches
                if (username == userinput)
                {
                    //Get password
                    string password = sr.ReadLine();

                    // Enter password
                    Console.Write("Please enter your password: ");
                    string userimput = Console.ReadLine();

                    // Check if it matches
                    if (userimput == password)
                    {
                        Console.WriteLine("Congradulations, you are logged in as " + username);
                    }
                    else
                    {
                        Console.WriteLine("Wrong Password");
                        Program.Main();
                    }
                }
                else
                {
                    Console.WriteLine("Wrong Username");
                    Program.Main();
                }

            }
            // Go back to main 
            else
            {
                Console.WriteLine("Please Sign Up");
                Program.Main();
            }

        }
    }
}