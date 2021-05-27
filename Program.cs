using System;
using System.Linq;
using Project3.AppData;

namespace Project3
{
    class Program
    {
        private static readonly ApplicationContext Application = new();
        static void Main(string[] args)
        {
            var das = Application.Projects.Select(p => p.NameProject);
            Console.WriteLine("Hello World!");
        }
    }
}
