public class Frases
{   
    List<string> _frases = new List<string>();

    public Frases() // construtor
    {    
        _frases.Add("Quem foi a pessoa mais interessante com quem interagi hoje?");
        _frases.Add("Qual foi a melhor parte do meu dia?");
        _frases.Add("Como vi a mão do Senhor em minha vida hoje?");
        _frases.Add("Qual foi a emoção mais forte que senti hoje?");
        _frases.Add("Se eu pudesse fazer uma coisa hoje, o que seria?");
    }

    public string FraseAleatoria()
    {
        Random fraseAleatoria = new Random();
        int numero = fraseAleatoria.Next(0, _frases.Count);
        return _frases[numero];
    }
}