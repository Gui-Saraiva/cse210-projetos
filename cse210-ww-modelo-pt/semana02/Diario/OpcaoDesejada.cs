public class OpcaoDesejada
{
    public OpcaoDesejada(string opcao)
    {
        List<string> diario = new List<string>(); // lista que recebe todo texto do diário.

        while (opcao != "5")
        {
            if (opcao == "1")
            {
                Frases frases = new Frases(); // "Frases" é o tipo do que seria uma variavel (string, int...) define o tipo do objeto. É um objeto personalizado.
                string frase = frases.FraseAleatoria(); // execute o metodo aleatorio da classe Frases e devolva uma frase.
                Console.WriteLine(frase); // imprime uma frase aleatória para o usuário responder.
                string resposta = Console.ReadLine(); // le a resposta do usuario.
                DateTime horaAtual = DateTime.Now;
                string dataTexto = horaAtual.ToString();
                diario.Add(dataTexto);
                diario.Add(frase); // adiciona a frase aleatoria na lista
                diario.Add(resposta); // adiciona a resposta do usuario na lista
            }
            else if (opcao == "2")
            {
                foreach (string registro in diario)
                {
                    Console.WriteLine(registro);
                }
            }
            else if (opcao == "3")
            {
                CarregarArquivo.Carregar();
            }
            else if (opcao == "4")
            {
                SalvarArquivo.Salvar(diario);
            }
            opcao = Entrada.ReceberEntrada(); // recebe um novo valor para opcao.
        }
    }
}