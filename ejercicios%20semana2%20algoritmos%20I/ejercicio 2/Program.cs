using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    class Program
    {
 public class triangulo
{
    public static void Main()
    {
        float primerNumero;
		float segundoNumero;
		float triangulo;
		
         Console.WriteLine("Escribe un numero");
        primerNumero = Convert.ToSingle(Console.ReadLine());
        triangulo = primerNumero;
		
		Console.WriteLine("Escribe el ancho deseado");
        segundoNumero = Convert.ToSingle(Console.ReadLine());
        triangulo = segundoNumero;
		 
        Console.WriteLine("El resultado esperado:" ) ; 
       
		Console.WriteLine("{0}{0}{0}{0}{0}{0} ", 
		triangulo, triangulo);
		
		Console.WriteLine("{0}{0}{0}{0}{0} ", 
		triangulo, triangulo);
			
       		Console.WriteLine("{0}{0}{0}{0} ", 
		triangulo, triangulo);
		
		Console.WriteLine("{0}{0}{0} ", 
		triangulo, triangulo);
		
		Console.WriteLine("{0}{0} ", 
		triangulo, triangulo);
		
		Console.WriteLine("{0} ", 
		triangulo, triangulo);

		}
}

        static void Main(string[] args)
        {
        }
    }
}
