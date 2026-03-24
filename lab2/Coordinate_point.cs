using System;


namespace lab2
{
    internal class Coordinate_point
    {
        double x;
        double y;

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public Coordinate_point()
        {
            x = 5;
            y = 6;
        }

        public Coordinate_point(double x,  double y)
        {
            this.X = x;
            this.Y = y;
        }

        public string View_representation()
        {
            return "{" + x + ";" + y + "}";

        }

        public override string ToString()
        {
            return View_representation();
        }          
    }
}
