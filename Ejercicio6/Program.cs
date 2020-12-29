using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int mul3 = 0, mul5 = 0, valor;

            for (int x = 1; x <= 10; x++){
                Console.Write("Valor " + x + ": ");
                valor = Convert.ToInt32(Console.ReadLine());
                
                if (valor % 3 == 0) {
                    mul3 = mul3 + 1;
                }
                else if(valor % 5 == 0){
                    mul5 = mul5 + 1;
                }
            }
            Console.WriteLine(mul3);
            Console.Write(mul5);
        }
    }
}
