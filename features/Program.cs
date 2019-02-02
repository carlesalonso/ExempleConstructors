using System;

namespace features
{

    class Point
    {
        public int X { get; }
        public int Y { get; }
        public Point() => (X, Y) = (0, 0);
        public Point(int x, int y) => (X, Y) = (x, y);
        public void GetCoordinates(out int x, out int y) =>
            (x, y) = (X, Y);

    }

    /* La classe OldPoint és equivalent a la classe Point
     * utilitzant els constructors de blocs i els atributs privats


    class Point

    {

        private readonly int _x;
        private readonly int _y;

        public int X
        {
            get
            {
                return _x;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
        }

        public OldPoint()
        {
            _x = 0;
            _y = 0;
        }

        public OldPoint(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void GetCoordinates(out int x, out int y)
        {
            x = X;
            y = Y;
        }
    }

    */

    class Pixel : Point

    {

        public int Color { get; }

        public Pixel(int x, int y, int color) : base(x, y) => Color = color;

        public int GetColor() => Color;

    }





    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(12, 10);
            var origin = new Point();
            var pixel = new Pixel(100, 200, 128);

            Console.WriteLine(Display(point));
            Console.WriteLine(Display(origin));
            Console.WriteLine(Display(pixel));



        }


        static string Display(object o)
        {
            switch (o)
            {
                case Point p when p.X == 0 && p.Y == 0:
               
                    return "origin";
                case Point p:
               
                        return $"({p.X},{p.Y})";
                default:
                    return "unknown";
            }

        }
    }
}
