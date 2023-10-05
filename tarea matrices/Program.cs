using System;

namespace tarea_matrices
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Ingrese el tamaño de la matriz cuadrada: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            Console.WriteLine("Ingrese los elementos de la matriz:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Elemento [{i}, {j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Elementos en la diagonal principal:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }

            Console.WriteLine("\n Elementos en la diagonal secundaria:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, n - 1 - i] + " ");
            }

            Console.ReadLine();
        }
    }
}
