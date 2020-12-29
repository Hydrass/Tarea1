using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double cant1 = 0, cant2 = 0, cant3 = 0, peso;
            do
            {
                Console.Write("Peso: ");
                peso = Convert.ToDouble(Console.ReadLine());

                if (peso > 10.2) {
                    cant1++;
                }
                else if (peso >= 9.2) {
                    cant2++;
                }
                else if (peso > 0) {
                    cant3++;
                }

            } while (peso != 0);

            double suma = cant1 + cant2 + cant3;

            Console.Write("Peso: " + cant1 + " " + cant2  + " " + cant3);

            Console.ReadKey();
        }
    }
}
