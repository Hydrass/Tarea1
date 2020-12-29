using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double aprobados = 0, reprobados = 0, nota;
            for (int x = 1; x <= 10; x++) { 
                Console.Write("Nota "+ x + ": ");
                nota = Convert.ToDouble(Console.ReadLine());

                if (nota >= 7)
                {
                    aprobados = aprobados +1;
                }
                else {
                    reprobados = reprobados +1;
                }
            }
            Console.WriteLine("Aprobados: " + aprobados);
            Console.Write("Reprobados: " + reprobados);
            Console.WriteLine();
        }
    }
}
