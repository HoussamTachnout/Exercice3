using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    class Point
    {
        private int X, Y;
        public Point(int X,int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public int GetX()
        {
            return X;
        }
        public void SetX(int X)
        {
            this.X = X;
        }
        public int GetY()
        {
            return Y;
        }
        public void SetY(int Y)
        {
            this.Y = Y;
        }
        public double Distance(Point P)
        {
            return Math.Sqrt(Math.Pow((P.GetX() - this.GetX()), 2) + Math.Pow((P.GetY() - this.GetY()), 2));
        }
        public int Egalite(Point P)
        {
            if ((P.X == X) && (P.Y == Y))
                return 1;
            else
                return 0;
        }

    }
}
