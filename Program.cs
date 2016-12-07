using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hey! What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome to this app, {0}!", name);
        }
    }
}
