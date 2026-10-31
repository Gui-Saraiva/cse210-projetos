using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> listaNumeros = new List<int>();
        
        int numeroLista = -1;
        float somaLista = 0;
        int qtdNumeros = 0;
        int maior = 0;
        int menor = int.MaxValue;

        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");

        while (numeroLista != 0)
        {
            Console.Write("Insira um número: ");
            string numero = Console.ReadLine();
            numeroLista = int.Parse(numero);

            if (numeroLista != 0)
            {
                listaNumeros.Add(numeroLista);
                somaLista += numeroLista;
                qtdNumeros++;

                if (numeroLista > maior)
                {
                    maior = numeroLista;
                }

                if (numeroLista < menor && numeroLista > 0)
                {
                    menor = numeroLista;
                }
            }
            else
            {
                float media = somaLista / qtdNumeros;

                Console.WriteLine($"A soma é: {somaLista}");
                Console.WriteLine($"A média é: {media}");
                Console.WriteLine($"O maior número é: {maior}");
                Console.WriteLine($"O menor número positivo é: {menor}");
                listaNumeros.Sort();
                listaNumeros.ForEach(Console.WriteLine);
            }
        }
    }
}