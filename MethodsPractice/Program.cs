using System;

namespace MethodsPractice
{
    class Program
    {
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);

                point.Move(null);
                Console.WriteLine("point is at ({0}, {1})", point.x, point.y);

                point.Move(100, 200);
                Console.WriteLine("point is at ({0}, {1})", point.x, point.y);
            }
            catch (Exception)
            {

                Console.WriteLine("unexpected error");
            }
        }

        static void UseParams()
        {
            var calculator = new Calculator();

            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            // if no params keyword
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));
        }

        static void Main(string[] args)
        {
            // var number = int.Parse("abc");
            int number;

            // returns boolean
            var result = int.TryParse("abc", out number);


            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("conversion failed");

        }
    }
}
