using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Rectangulo rectangulo = new Rectangulo();

                //Console.WriteLine("Ingresar x1");
                //double x1 = rectangulo.x1 = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("Ingresar y1");
                //double y1 = rectangulo.y1 = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("Ingresar x2");
                //double x2 = rectangulo.x2 = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("Ingresar y2");
                //double y2 = rectangulo.y2 = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("Ingresar x3");
                //double x3 = rectangulo.x3 = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("Ingresar y3");
                //double y3 = rectangulo.y3 = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("Ingresar x4");
                //double x4 = rectangulo.x4 = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("Ingresar y4");
                //double y4 = rectangulo.y4 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingresar la coordenada del primer punto");
                double x1 = Double.Parse(Console.ReadLine());
                //Console.WriteLine("Ingresar y1");
                double y1 = Double.Parse(Console.ReadLine());
                rectangulo.punto1 = new Punto(x1, y1);

                Console.WriteLine("Ingresar la coordenada del segundo punto");
                double x2 = Double.Parse(Console.ReadLine());
                //Console.WriteLine("Ingresar y2");
                double y2 = Double.Parse(Console.ReadLine());
                rectangulo.punto2 = new Punto(x2, y2);

                Console.WriteLine("Ingresar la coordenada del tercer punto");
                double x3 = Double.Parse(Console.ReadLine());
                //Console.WriteLine("Ingresar y3");
                double y3 = Double.Parse(Console.ReadLine());
                rectangulo.punto3 = new Punto(x3, y3);

                Console.WriteLine("Ingresar la coordenada del cuarto punto");
                double x4 = Double.Parse(Console.ReadLine());
                //Console.WriteLine("Ingresar y4");
                double y4 = Double.Parse(Console.ReadLine());
                rectangulo.punto4 = new Punto(x4, y4);

                double bs;
                bs = rectangulo.Base(rectangulo.punto1,rectangulo.punto2);

                double h;
                h= rectangulo.Altura(rectangulo.punto2,rectangulo.punto3);

                double area;
                area = rectangulo.Area(bs, h);

                double perimetro;
                perimetro = rectangulo.Perimetro(bs, h);

                Console.WriteLine("El area es :" + area);
                Console.WriteLine("El perimetro es:" + perimetro);

                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }



        }
    }
}

