using System;

class Program
{
    static void Main(string[] args)
    {
        ExibirBoasVindas();

        static void ExibirBoasVindas()
        {
            Console.WriteLine("Bem vindo ao programa!");

            string nome = PerguntarNomeUsuario();
            int numeroFavorito = PerguntarNumeroFavorito();
            int numeroAoQuadrado = ElevarAoQuadrado(numeroFavorito);
            ExibirResultado(nome, numeroAoQuadrado);
        }

        static string PerguntarNomeUsuario()
        {
            Console.Write("Por favor, insira seu nome: ");
            string nome = Console.ReadLine();
            return nome;
        }

        static int PerguntarNumeroFavorito()
        {
            Console.Write("Por favor, insira seu número favorito: ");
            string numero = Console.ReadLine();
            int numeroFavorito = int.Parse(numero);
            return numeroFavorito;
        }

        static int ElevarAoQuadrado(int numAoQuadrado)
        {
            int numElevado = numAoQuadrado * numAoQuadrado;
            return numElevado;
        }

        static void ExibirResultado(string nome, int numAoQuadrado)
        {
            Console.Write($"{nome} o quadrado do seu número favorito é: {numAoQuadrado}");
        }

    }
}
