using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma = 0, valor, promedio;

            for(int x = 1; x <= 10; x++){
                 Console.Write("Valor "+ x + ": ");
                valor = Convert.ToDouble(Console.ReadLine());

                suma  = suma + valor;
                
            }
            promedio = suma / 10;


            Console.Write("El promedio es: " + promedio);
        }
    }
}
