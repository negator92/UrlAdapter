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
                Console.WriteLine((input.Remove(0, input.LastIndexOf("http")).Replace("%3A", ":").Replace("%2F", "/")).Remove(input.IndexOf(".html")+5));
                Console.WriteLine("Press enter to continue or q to quit");
            } while (Console.ReadLine() != "q");
        }
    }
}
