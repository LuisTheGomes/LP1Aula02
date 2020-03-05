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

            double V = Math.PI * Math.Pow(r, 2) * a;

            double S = 2 * Math.PI * r * (r + a);

            Console.WriteLine("Volume: {0}\nArea de superficie: {1}", V, S);

        }
    }
}
