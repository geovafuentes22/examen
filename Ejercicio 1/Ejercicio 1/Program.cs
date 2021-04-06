using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black; Console.BackgroundColor = ConsoleColor.White; Console.Clear();
            Console.Title = ("Calculo de promedio");
            String nombreAlu1;
            Double[] notas = new Double[5];
            Double[] promedios = new Double[5];
            double promedio = 0;
            //Alumno 1 Do While
            for (int z = 0; z < 5; ++z)
            {
                Console.Write("Digitar el nombre del estudiante: ");
                nombreAlu1 = Console.ReadLine();
                Console.WriteLine("El nombre del estudiante es: " + nombreAlu1);
                for (int x = 0; x < 5; ++x)
                {
                    do
                    {
                        Console.WriteLine($"ingrese la nota: #{x}");
                        notas[x] = Double.Parse(Console.ReadLine());



                        if (notas[x] < 0 || notas[x] > 10)
                        {
                            Console.WriteLine("Los datos son errores , por favor ingresar numeros entre 0 y 10");
                        }




                    } while (notas[x] < 0 || notas[x] > 10);




                    promedio += notas[x];




                }
                promedio /= 5;




                if (promedio > 7)
                {
                    Console.WriteLine("Aprobado");
                    Console.WriteLine("el promedio es: " + promedio);



                }
                else if (promedio >= 4 || promedio < 7)
                {
                    Console.WriteLine("Regular");
                    Console.WriteLine("el promedio es: " + promedio);




                }
                else if (promedio < 4)
                {
                    Console.WriteLine("Reprobado");
                    Console.WriteLine("el promedio es: " + promedio);




                }



                Console.ReadKey();
            }
        }
    }
}
