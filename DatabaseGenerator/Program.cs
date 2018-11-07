using System;

namespace DatabaseGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new GodClass();
            generator.AskForAll();
            generator.Generate();
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
