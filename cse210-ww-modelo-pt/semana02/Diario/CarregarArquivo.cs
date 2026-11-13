public class CarregarArquivo
{
    public static void Carregar()
    {
        Console.Write("Nome do arquivo: ");
        string arquivo = Console.ReadLine();

        String[] linhas = System.IO.File.ReadAllLines(arquivo);

        foreach (string linha in linhas)
        {
            Console.WriteLine(linha);
        }
    }
}