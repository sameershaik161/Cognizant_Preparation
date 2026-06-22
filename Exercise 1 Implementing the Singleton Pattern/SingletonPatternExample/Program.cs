
// 231fa04898@gmail.com
using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            logger1.Log("First Message");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("Second Message");

            Console.WriteLine();

            if (logger1 == logger2)
            {
                Console.WriteLine("Only one Logger instance exists.");
            }
            else
            {
                Console.WriteLine("Multiple instances exist.");
            }
        }
    }
}