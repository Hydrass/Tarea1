using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int cant = 0;
            int vl;

            do {
                Console.Write("valor: ");
                vl = Convert.ToInt32(Console.ReadLine());

                suma = suma + vl;
                cant = cant + 1;

            } while (vl != 0);

            if (cant != 0)
            {
                int promedio = suma / cant;
                Console.WriteLine("Promedio: " + promedio);
            }
            else {
                Console.WriteLine("No se ingresaron valores");
            }

        }
    }
}
