using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)

        {
            string nombreTienda;
            Double ganancia, ganancias, numeroEmpleados;
            Console.ForegroundColor = ConsoleColor.Black; Console.BackgroundColor = ConsoleColor.White; Console.Clear();
            int i;
            for (i = 1; i <= 2; ++i )
            {

                Console.Title = "Ganancia por sucursal";
                Console.WriteLine("Introduzca el nombre de la tienda");
                nombreTienda = Console.ReadLine();

                do
                {
                    Console.WriteLine($"Introduzca la ganancia total de la sucursal: {nombreTienda} ");
                    ganancia = Double.Parse(Console.ReadLine());
                    if (ganancia < 0)
                    {
                        Console.WriteLine("Ingrese numeros positivos");

                    }
                    else if (ganancia < 1000)
                    {
                        Console.WriteLine("Ingrese ganancias mayores a $1000");

                    }
                    ganancias = ganancia++;
                } while (ganancia < 0 || ganancia < 1000);
                do
                {
                    Console.WriteLine($"Introduzca el numero de empleados que hay en la sucursal: {nombreTienda}");
                    numeroEmpleados = Double.Parse(Console.ReadLine());

                    if (numeroEmpleados < 10)
                    {
                        Console.WriteLine("No podemos trabajar con empleados menores a 10 ingrese nuevamente");
                    }

                } while (numeroEmpleados < 10);


                if (ganancia > 30000)
                {
                    Console.WriteLine($"Tienda: {nombreTienda} : Bien hecho\n");
                    Console.WriteLine($"Ganancias: {ganancia}\n");
                    Console.WriteLine($"Numero de empleados: {numeroEmpleados}");
                    
                }
                if  (ganancia < 30000)
                    {
                    Console.WriteLine($"Tienda: {nombreTienda} : Regular\n");
                    Console.WriteLine($"Ganancias: {ganancia}\n");
                    Console.WriteLine($"Numero de empleados: {numeroEmpleados}");

                }
                Console.ReadKey();
                Console.WriteLine($"ganancias totales: {ganancias}");
            }
        }
    }
}
