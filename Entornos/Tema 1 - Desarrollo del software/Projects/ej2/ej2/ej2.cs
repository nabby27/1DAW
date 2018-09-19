using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ej2
{
    class ej2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime tu nombre");
            String nombre = Console.ReadLine();

            Console.WriteLine("Dime tu fecha de nacimineto");
            String fecha = Console.ReadLine();

            Console.WriteLine("Dime tu codigo postal");
            String cp = Console.ReadLine();

            Console.WriteLine("Dime tu ciudad");
            String ciudad = Console.ReadLine();

            Console.WriteLine("Dime tu sueldo");
            String sueldo = Console.ReadLine();

            Console.WriteLine("Tu nombre es: " + nombre);
            Console.WriteLine("Tu fecha de nacimineto es: " + fecha);
            Console.WriteLine("Tu codigo postal es: {0,10}", cp);
            Console.WriteLine("Tu ciudad es: {0,10}", ciudad);
            Console.WriteLine("Tu sueldo es: {0,10}", sueldo);

            Console.Read();
        }
    }
}
