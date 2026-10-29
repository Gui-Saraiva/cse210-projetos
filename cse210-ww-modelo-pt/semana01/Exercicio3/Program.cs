using System;

class Program
{
    static void Main(string[] args)
    {           
        string resposta = "sim";

        while (resposta == "sim")
        {
            Random geradorAleatorio = new Random();
            int numeroMagico = geradorAleatorio.Next(1, 101);
            Console.WriteLine(numeroMagico);
            
            int palpite = -1;
            int tentativas = 1;

            while (numeroMagico != palpite)
            {   
                Console.Write("Acerte o número mágico: ");
                string numeroPalpite = Console.ReadLine();
                palpite = int.Parse(numeroPalpite);

                if (palpite == numeroMagico)
                {
                    Console.WriteLine("você adivinhou!");
                    Console.WriteLine($"{tentativas} tentativas.");
                    
                }
                else if (palpite < numeroMagico)
                {
                    Console.WriteLine("Mais alto");
                    tentativas++;
                }
                else
                {
                    Console.WriteLine("Mais baixo");
                    tentativas += 1;
                }
            }

            Console.Write("Jogar novamente? ");
            resposta = Console.ReadLine();
        }

        

        
    }
}