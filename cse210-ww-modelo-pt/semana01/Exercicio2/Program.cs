using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite sua nota: ");
        string notaUsuario = Console.ReadLine(); // a entrada de dados é sempre feita em string
        int nota = int.Parse(notaUsuario); // converte para int    
        string notaFinal = "Z";

        if (nota >= 90)
        {
            notaFinal = "A";
        }
        else if (nota >= 80)
        {
            notaFinal = "B";
        }
        else if (nota >= 70)
        {
            notaFinal = "C";
        }
        else if (nota >= 60)
        {
            notaFinal = "D";
        }
        else
        {
            notaFinal = "F";
        }

        int ultimoDigito = nota % 10;

        if (ultimoDigito >= 7)
        {
            Console.WriteLine($"nota {notaFinal}+");
        }
        else if (ultimoDigito <= 3)
        {
            Console.WriteLine($"nota {notaFinal}-");
        }
        else
        {
            Console.WriteLine($"nota {notaFinal}");
        }

        if (nota >= 60)
        {
            Console.Write("Parabéns você passou!");
        }
        else
        {
            Console.Write("Não desista, continue estudando, você consegue.");
        }
    }
}