using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiploD3, multiploD5, multiploDAmbos, valor, x;
            string linea;
            multiploD3 = 0;
            multiploD5 = 0;
            multiploDAmbos = 0;

            for ( x = 1; x <= 10; x++)
            {

                do
                {
                    Console.WriteLine($"#{x}: Ingrese la cantidad a evaluar como multiplo: ");
                    linea = Console.ReadLine();
                    valor = int.Parse(linea);
                    if (valor < 0 )
                    {
                        Console.WriteLine("Por favor ingrese un numero positivos");

                    }
                    if (valor >=501){
                        Console.WriteLine("No puedes ingresar mayores de 500");

                    }
                } while (valor < 0 || valor > 500);

                if (valor % 3 == 0)
                {
                    multiploD3 = multiploD3 + 1;
                }
                if ( valor % 5 == 0)
                {
                    multiploD5 = multiploD5 + 1;
                }
                else if (valor % 3 == 0 || valor % 5 == 0)
                {
                    multiploDAmbos = multiploDAmbos + 1;
                }
            }
            Console.Write($"Cantidad de valores ingresados múltiplos de 3 es: {multiploD5}\n");
            Console.Write($"Cantidad de valores ingresados múltiplos de 5 es: {multiploD5}\n"); 
            Console.Write($"Cantidad de valores ingresados múltiplos de 3 y 5 es: {multiploDAmbos}\n"); 

            Console.ReadKey();
        }
    }
}
