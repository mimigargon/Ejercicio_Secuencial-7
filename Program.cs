using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_Secuencial_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer factor");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo factor");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es: {0}", num1 * num2);
        }
    }
}
