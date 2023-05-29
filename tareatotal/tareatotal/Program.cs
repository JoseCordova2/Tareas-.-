using System;
using System.Security.Cryptography.X509Certificates;
using tareatotal.Clases;

namespace tareatotal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Nombres nombres = new Nombres();
            

            nombres.Menu();
            nombres.acceder();
            double final = nombres.acceder();

            Console.WriteLine("este fue tu total: "+ final);
        }
    }
}
