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

                Console.WriteLine("Ingresar x1");
                double x1 = rectangulo.x1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresar y1");
                double y1 = rectangulo.y1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresar x2");
                double x2 = rectangulo.x2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresar y2");
                double y2 = rectangulo.y2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresar x3");
                double x3 = rectangulo.x3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresar y3");
                double y3 = rectangulo.y3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresar x4");
                double x4 = rectangulo.x4 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresar y4");
                double y4 = rectangulo.y4 = Convert.ToDouble(Console.ReadLine());

                double bs;
                bs = rectangulo.Base(x2, x1, y1, y2);

                double h;
                h = rectangulo.Altura(x3, y3, y4, x4);

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

