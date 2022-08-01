using AddNumber;
using System;
using NLog;

namespace AddNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO WORLD!");
            AddNumber1 obj = new AddNumber1();
            obj.Sum(1,0);

        }
    }
}