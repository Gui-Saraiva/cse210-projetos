using System;

class Program
{
    static void Main(string[] args)
    {           
        BibliotecaEscrituras biblioteca = new BibliotecaEscrituras();
        Escritura escritura = biblioteca.Sorteio();
        
        Console.Write(escritura.ObterReferencia() + " ");
        Console.WriteLine(escritura.ObterTexto());
        Console.WriteLine("");

        string decisaoUsuario = "decida";
        while(decisaoUsuario != "sair" && escritura.EstaCompletamenteOculta() == false)
        {
            Console.WriteLine("Aperte Enter para continuar ou digite 'sair' para finalizar:");
            decisaoUsuario = Console.ReadLine();

            if(decisaoUsuario == "")
            {   
                Console.Clear();
                Console.Write(escritura.ObterReferencia() + " ");
                escritura.OcultarPalavrasAleatorias(5);
                Console.WriteLine(escritura.ObterTexto() + " ");
                Console.WriteLine("");             
            }
        }        
    }
}