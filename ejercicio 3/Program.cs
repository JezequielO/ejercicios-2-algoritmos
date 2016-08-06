using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    class Program
    {
        static void Main()
        {
            string usuario = "x";
            int clave = 1;


            Console.Write("Ingrese el nombre del usuario:");
            usuario = Console.ReadLine();

            Console.Write("Escribe la contraseña ");
            clave = Int16.Parse(Console.ReadLine());

            if (usuario == "x" && clave == 1)
                Console.Write("Bienvenido");

            else

                Console.Write("Usuario incorrecto");
            Console.Write(" \n Presione < Enter > para continuar...");

            Console.ReadKey();
        }
    }
}
