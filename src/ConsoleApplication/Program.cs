using System;
using ClassLibrary;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var train = new Train();
            train.StartEngines();
            Console.WriteLine("Hello World!");
        }
    }
}