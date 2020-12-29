using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            do
            {
                Console.WriteLine("Introduce un numero: ");
                valor = Convert.ToInt32(Console.ReadLine());

                if (valor >= 100)
                {
                    Console.WriteLine("El numero: " + valor + " tiene 3 digitos");
                }
                else if (valor >= 10){
                    Console.WriteLine("El numero: " + valor + " tiene 2 digitos");
                }

                else if (valor < 9){
                    Console.WriteLine("El numero: " + valor + " tiene 1 digito");
                }

            } while (valor != 0);


            Console.ReadKey();

        }
    }
}
