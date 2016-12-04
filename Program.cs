using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hey! What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}, welcome to this app!", name);
        }
    }
}
