using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double x1, x2, delta;
            bool vlValido;


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ---------------- ");
            Console.WriteLine(" --- Bhaskara --- ");
            Console.WriteLine(" ---------------- ");
            Console.ResetColor();

            Console.Write("Digite o valor de a: ");
            vlValido = Double.TryParse(Console.ReadLine(), out a);


            if (a != 0)
            {
                Console.Write("Digite o valor de b: ");
                vlValido = Double.TryParse(Console.ReadLine(), out b);
                Console.Write("Digite o valor de c: ");
                vlValido = Double.TryParse(Console.ReadLine(), out c);
                delta = Math.Pow(b, 2) - (4 * a * c);

                if (delta > 0)
                {
                    double raizQuad = Math.Sqrt(delta);
                    Console.WriteLine($"\ndelta = {delta} A sua Raiz Quadrada é {raizQuad:N1} ");
                    x1 = (((b * (-1)) + raizQuad) / (2 * a));

                    Console.WriteLine($"\nX1 = {x1:N1}");
                    x2 = (((b * (-1)) - raizQuad) / (2 * a));

                    Console.WriteLine($"X2 = {x2:N1}");
                }
                else
                {
                    Console.WriteLine("\nA equação não possui raízes reais");
                }
            }
            else
            {
                Console.WriteLine("\nNão é uma equação de segundo grau.");
            }


        }
    }
}
