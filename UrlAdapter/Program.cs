using System;

namespace UrlAdapter
{
    internal class Program
    {
        static void Main()
        {
            string input;
            do
            {
                Console.WriteLine("Enter url: ");
                input = Console.ReadLine();
                Console.WriteLine((input.Substring(input.LastIndexOf("http"), input.IndexOf(".html") + 5 - input.LastIndexOf("http"))).Replace("%3A", ":").Replace("%2F", "/"));
                Console.WriteLine("Press enter to continue or q to quit");
            } while (Console.ReadLine() != "q");
        }
    }
}
