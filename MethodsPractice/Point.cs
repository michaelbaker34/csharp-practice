using System;


namespace MethodsPractice
{
    public class Point
    {
        public int x;
        public int y;


        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(Point newLocation)
        {
            this.x = newLocation.x;
            this.y = newLocation.y;
        }
    }
}
