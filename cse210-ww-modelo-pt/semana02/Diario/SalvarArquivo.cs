public class SalvarArquivo {
    public static void Salvar(List<string> diario)
    {
        Console.Write("Nome do arquivo: ");
        string arquivo = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(arquivo)) // salva dados em um arquivo externo. Depois fecha o arquivo automaticamente com "using".
        {
            foreach (string salvarArquivo in diario)
            {
                writer.WriteLine(salvarArquivo);
            }
        }
    }
}