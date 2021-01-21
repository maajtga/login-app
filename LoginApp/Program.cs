using System;

namespace LoginApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Executable Title
            Console.Title = "LoginApp";
            
            // User Prompt to enter Username
            Console.WriteLine("Please enter your Username:");


            // Wait for user Input before closing
            Console.ReadKey();
        }
    }
}
