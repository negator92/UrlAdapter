using System;

namespace UrlAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string a in args)
            {
                Console.WriteLine(a.Remove(0, a.LastIndexOf("http")).Replace("%3A", ":").Replace("%2F", "/"));
            }
        }
    }
}
