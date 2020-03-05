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

            double pi = 3.1415926;

            double V = pi * Math.Pow(r, 2) * a;

            double S = 2 * pi * r * (r + a);

            Console.WriteLine("Volume: {0}\nArea de superficie: {1}", V, S);



        }
    }
}
