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

    public class Geom
    {
        public static bool check(MyRectangle rect1, MyRectangle rect2)
        {
          MyPoint C = new MyPoint (rect2.A.X, rect2.B.Y);
          MyPoint D = new MyPoint (rect2.B.X, rect2.A.Y);
          if (CheckInPoint(rect1, rect2.A) || CheckInPoint(rect1, rect2.B)
          || CheckInPoint(rect1, C) || CheckInPoint(rect1, D))
              return true;
          return false;

        }
        public static bool CheckInPoint(MyRectangle rect, MyPoint pnt)
        {
            if ((Math.Min(rect.A.X, rect.B.X) <= pnt.X && pnt.X <= Math.Max(rect.A.X, rect.B.X))
            && (Math.Min(rect.A.Y, rect.B.Y) <= pnt.X && pnt.Y <= Math.Max(rect.A.Y, rect.B.Y)))
                return true;
            return false;
        }
    }
}