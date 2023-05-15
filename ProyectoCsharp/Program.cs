using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a1, a2, res;
            int opt;
            Console.Title = "Calculadora";
            Console.ForegroundColor = ConsoleColor.Green;

            do
            {
                Console.Clear();
                Console.WriteLine("PROYECTO DE CALCULADORA BASICA");
                Console.WriteLine("Bienvenido");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("OPERACION SUMA");
                        Console.WriteLine("Ingrese el primer valor numerico");
                        a1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor numerico");
                        a2 = Convert.ToDouble(Console.ReadLine());
                        res = a1 + a2;
                        Console.WriteLine("Resultado es:" + (res));
                        break;


                    case 2:
                        Console.Clear();
                        Console.WriteLine("OPERACION RESTA");
                        Console.WriteLine("Ingrese el primer valor numerico");
                        a1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor numerico");
                        a2 = Convert.ToDouble(Console.ReadLine());
                        res = a1 - a2;
                        Console.WriteLine("Resultado es:" + (res));
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("OPERACION MULTIPLICAR");
                        Console.WriteLine("Ingrese el primer valor numerico");
                        a1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor numerico");
                        a2 = Convert.ToDouble(Console.ReadLine());
                        res = a1 * a2;
                        Console.WriteLine("Resultado es:" + (res));
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("OPERACION DIVIDIR");
                        Console.WriteLine("Ingrese el primer valor numerico");
                        a1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor numerico");
                        a2 = Convert.ToDouble(Console.ReadLine());
                        res = a1 / a2;
                        Console.WriteLine("Resultado es:" + (res));
                        break;

                    case 5:
                        Console.WriteLine("GRACIAS POR USAR ESTA CALCULADORA");
                        break;
                    default:
                        Console.WriteLine("OPCION INVALIDA");
                        break;
                }
                Console.ReadLine();

            } while ((opt > 0) && (opt <= 4));
        }
    }
}
