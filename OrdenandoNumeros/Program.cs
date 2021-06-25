using System;

namespace OrdenandoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
                int [] numeros = new int[5];

                for(int i =0; i < numeros.Length; i++)
                {
                    Console.WriteLine("Digite um número: ");
                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                }

                Array.Sort(numeros);
                Console.Write("\n\n");

                foreach (int i in numeros)
                {
                    Console.WriteLine(i);
                }

        }
    }
}