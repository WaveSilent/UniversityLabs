using System;


namespace lab2
{
    internal class Line
    {
        string x1_y1;
        string x2_y2;

        public string X1_Y1
        {
            get
            {
                return x1_y1;
            }
            set
            {
                x1_y1 = value;
            }
        }

        public string X2_Y2
        {
            get
            {
                return x2_y2;
            }
            set
            {
                x2_y2 = value;
            }
        }

        public Line(string x1_y1, string x2_y2)
        {
            this.X1_Y1 = x1_y1;
            this.X2_Y2 = x2_y2;
        }

        public string Start_point()
        {
            return X1_Y1;
        }
        public string End_point()
        {
            return X2_Y2;
        }

        public override string ToString()
        {
            return "линия от " + X1_Y1 + " до " + X2_Y2; ;
        }
    }
}
