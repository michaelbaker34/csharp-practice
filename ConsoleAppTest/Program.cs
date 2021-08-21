using System;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 0;
            int count = 10;
            float total = 20.20f;
            char character = 'a';
            string firstName = "Joe";
            bool isOn = true;

            /*
            var number = 0;
            var count = 10;
            var total = 20.20f;
            var character = 'a';
            var firstName = "Joe";
            var isOn = true;
            */


            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(total);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isOn);


            // format string
            Console.WriteLine("byte: {0} - {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("float: {0} - {1}", float.MinValue, float.MaxValue);
        }
    }
}
