using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Rectangulo
    {
        public double x1 { get; set; }
        public double y1 { get; set; }
        public double x2 { get; set; }
        public double y2 { get; set; }
        public double x3 { get; set; }
        public double y3 { get; set; }
        public double x4 { get; set; }
        public double y4 { get; set; }


        public double Base(double x2, double x1, double y1, double y2)
        {
            double bs = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return bs;
        }

        public double Altura(double x3, double y3, double y4, double x4)
        {
            double h = Math.Sqrt(Math.Pow((x3 - x4), 2) + Math.Pow((y3 - y4), 2));
            return h;
        }

        public double Perimetro(double bs, double h)
        {
            double p = (2 * bs) + (2 * h);
            return p;
        }

        public double Area(double bs, double h)
        {
            double a = bs * h;
            return a;
        }
    }
}


