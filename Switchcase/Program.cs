using System;

namespace Switchcase
{
    class Program
    {
        public static object userInput { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject");
            var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "math":
                    Console.WriteLine("Math is to hard");
                    break;
                case "reading":
                    Console.WriteLine("reading can be fun");
                    break;
                default:
                    Console.WriteLine("That sounds interesting");
                    break;


            }





        }
    }
}
