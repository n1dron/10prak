/*using System;
using System.Diagnostics.Metrics;
using System.IO;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "LOGIN";
            string username, password, username1, password1 = string.Empty;
            Console.WriteLine("Enter a username: ");
            username = Console.ReadLine();
            Console.WriteLine("Enter a paasword :");
            password = Console.ReadLine();

            using (StreamReader sr = new StreamReader(File.Open("D:\\data.txt", FileMode.Open)))
            {
                username1 = sr.ReadLine();
                password = sr.ReadLine();
                sr.Close();
            }
        }
    }
}*/