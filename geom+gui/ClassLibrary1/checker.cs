using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MyPoint
    {
        public double X;
        public double Y;
        public MyPoint(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    public class MyRectangle
    {
        public MyPoint A;
        public MyPoint B;
        public MyRectangle(MyPoint a, MyPoint b)
        {
            A = a;
            B = b;
        }
    }
   
    public class Geometry
    {
        public static bool check(MyRectangle rect1, MyRectangle rect2)
        {
            if (((rect1.B.X >= rect2.A.X) && (rect1.B.Y >= rect2.A.Y))
            || ((rect1.A.X <= rect2.B.X) && (rect1.A.Y <= rect2.B.Y))
            || ((rect1.B.X >= rect2.A.X) && (rect1.A.Y <= rect2.B.Y))
            || ((rect1.A.X <= rect2.B.X) && (rect1.B.Y >= rect2.A.Y)))
                return true;
            else return false;
        }
    }
}
