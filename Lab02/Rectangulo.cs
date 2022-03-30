using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Rectangulo
    {
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

        public double Base2(Punto punto3,Punto punto4)
        {
            double bs2= Math.Sqrt(Math.Pow((punto3.x -punto4.x), 2) + Math.Pow((punto3.y-punto4.y), 2));
            return bs2;
        }

        public double Altura(Punto punto2, Punto punto3)
        {
            double h = Math.Sqrt(Math.Pow((punto2.x - punto3.x), 2) + Math.Pow((punto3.y - punto2.y), 2));
            return h;
        }

        public double Altura2(Punto punto1, Punto punto4)
        {
            double h2 = Math.Sqrt(Math.Pow((punto1.x - punto4.x), 2) + Math.Pow((punto4.y- punto1.y), 2));
            return h2;
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


