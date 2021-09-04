using System;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(10, 20);

            point.Move(new Point(40, 60));
            Console.WriteLine("point is at ({0}, {1})", point.x, point.y);

            point.Move(100, 200);
            Console.WriteLine("point is at ({0}, {1})", point.x, point.y);
        }
    }
}
