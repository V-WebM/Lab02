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

                double bs2;
                bs2= rectangulo.Base2(rectangulo.punto3, rectangulo.punto4);

                double h;
                h= rectangulo.Altura(rectangulo.punto2,rectangulo.punto3);

                double h2;
                h2 = rectangulo.Altura2(rectangulo.punto1, rectangulo.punto4);

                double area;
                double perimetro;

                if (bs==bs2)
                {
                    if (h == h2)
                    {
                        area = rectangulo.Area(bs, h);
                        perimetro = rectangulo.Perimetro(bs, h);

                        Console.WriteLine("El area es :" + area);
                        Console.WriteLine("El perimetro es:" + perimetro);
                    }
                    else {
                        Console.WriteLine("La figura registrada no es un rectangulo");
                    }
                }
                else 
                {
                    Console.WriteLine("La figura registrada no es un rectangulo");
                }

                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }



        }
    }
}

