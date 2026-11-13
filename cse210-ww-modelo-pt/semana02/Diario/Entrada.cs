class Entrada
{
    public static string ReceberEntrada()
    {
    Console.WriteLine("Bem-Vindo ao programa Diário!");
    Console.WriteLine("Por favor selecione uma das seguintes opções: ");
    Console.WriteLine("1. Escrever ");
    Console.WriteLine("2. Exibir ");
    Console.WriteLine("3. Carregar ");
    Console.WriteLine("4. Salvar ");
    Console.WriteLine("5. Sair ");
    Console.Write("O que você gostaria de fazer? ");
    string _opcao = Console.ReadLine();
    return _opcao;
    }
}
