using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, Suma;
            Console.WriteLine("Ingrese 2 numeros: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            Suma = n1 + n2;
            Console.WriteLine("El resultado de la suma es: " + Suma);
        }
    }
}
