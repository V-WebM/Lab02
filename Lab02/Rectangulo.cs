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

        //Con Punto

        public Punto punto1 { get; set; }
        public Punto punto2 { get; set; }
        public Punto punto3 { get; set; }
        public Punto punto4 { get; set; }


        public double Base(Punto punto1, Punto punto2)
        {
            double bs = Math.Sqrt(Math.Pow((punto2.x - punto1.x), 2) + Math.Pow((punto2.y - punto1.y), 2));
            return bs;
        }

        public double Altura(Punto punto2, Punto punto3)
        {
            double h = Math.Sqrt(Math.Pow((punto2.x - punto3.x), 2) + Math.Pow((punto3.y - punto2.y), 2));
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


