using System;

namespace UrlAdapter
{
    internal class Program
    {
        private static void Main()
        {
            do
            {
                Console.WriteLine("Enter url: ");
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input) && string.IsNullOrWhiteSpace(input))
                    return;
                var httpLastIndex = input.LastIndexOf("http");
                Console.WriteLine(input
                    .Substring(httpLastIndex,
                        (input.Contains(".html")
                            ? (input.IndexOf(".html") + 5 - httpLastIndex)
                            : input.Length - httpLastIndex)).Replace("%3A", ":").Replace("%2F", "/"));
                Console.WriteLine("Press enter to continue or q to quit");
            } while (Console.ReadLine() != "q");
        }
    }
}