using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Altura: ");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Raio: ");

            int r = Convert.ToInt32(Console.ReadLine());

            double V = 3.1415926*Math.Pow(r,2)*a ; 

            Console.WriteLine("Volume: {0}",V);

        }
    }
}
