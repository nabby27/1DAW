using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ej1
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Hola mundo");
            Console.WriteLine("");
            Console.WriteLine(""); 
            
            Console.Write(99); //comentario
            Console.WriteLine("99");
            Console.WriteLine("La suma de {0} y {1} es {2}", 100, 130, 100 + 130);
            Console.WriteLine("");
            Console.WriteLine(""); 
            
            Console.WriteLine("\"Justificación a la izquierda de un campo de anchura 10: {0, -10}\"", 99);
            Console.WriteLine("\"Justificación a la izquierda de un campo de anchura 10: {0, 10}\"", 99);
            Console.WriteLine("");
            Console.WriteLine(""); 
            
            Console.WriteLine("Formato de moneda - {0:C} {1:C4}", 88.8, 888.8);
            Console.WriteLine("Formato entero - {0:D5}", 88);
            Console.WriteLine("Formato exponencial - {0:E}", 888.8);
            Console.WriteLine("Formato de punto fijo - {0:F3}", 888.8888);
            Console.WriteLine("Formato general - {0:G}", 888.8888);
            Console.WriteLine("Formato de número - {0:N}", 8888888.8);
            Console.WriteLine("Formato hexadecimal - {0:X4}", 88);
            Console.WriteLine("");
            Console.WriteLine("");

            string input = Console.ReadLine();
            Console.WriteLine("{0}", input);
                        
            Console.Read();
		}
	}
}
