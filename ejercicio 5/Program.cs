using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float v1;
            Console.Clear();
            Console.WriteLine("Area de un Circulo y su perimetro");
            Console.WriteLine("Digite radio del circulo");
            v1 = float.Parse(Console.ReadLine());
            double v3 = 2 * 3.1416 * v1;//perimetro
            double v4 = 3.1416 * (Math.Pow(v1, 2));//area
            Console.WriteLine("Area del Ciruclo: " + v4 + "cm^2");
            Console.WriteLine("Perimetro del Ciruclo: " + v3 + "cm");
            Console.ReadKey();
        }




    }
}

