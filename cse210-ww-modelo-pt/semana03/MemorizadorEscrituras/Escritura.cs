using System.Collections.Generic;
public class Escritura
{   
    // variaveis membro
    private Referencia _referencia;
    private List<Palavra> _palavras = new List<Palavra>();

    // construtor
    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;        

        string[] versiculo = []; // cria um array vazio
        versiculo = texto.Split();

        foreach(string palavra in versiculo) {
            Palavra objetoPalavra = new Palavra(palavra); // palavra é a variável do foreach
            _palavras.Add(objetoPalavra); // add todas as palavras percorridas na lista _palavras
        }
    }

    // metodos
    public void OcultarPalavrasAleatorias(int numeroParaOcultar)
    {
        Random aleatorio = new Random();
        int ocultadas = 0;
        int naoOcultadas = 0;

        foreach(Palavra palavra in _palavras)
        {
            if(palavra.EstaOculta() == false)
            {
                naoOcultadas ++;
            }
        }

        if(numeroParaOcultar > naoOcultadas)
        {
            numeroParaOcultar = naoOcultadas;
        }
        
        while (ocultadas < numeroParaOcultar)
        {
            int numAleatorio = aleatorio.Next(_palavras.Count); // pega um numero aleatorio na qtde de palavras do versiculo

            if (_palavras[numAleatorio].EstaOculta() == false)
            {
                _palavras[numAleatorio].Ocultar();
                ocultadas++;
            }
        }
    }

    public string ObterTexto()
    {   
        string versiculoCompleto = "";

        foreach(Palavra palavra in _palavras) // Palavra é o tipo personalizado da lista
        {
            versiculoCompleto += palavra.ObterTexto() + " "; // add cada palavra do objeto com um espaço 
        }

        return versiculoCompleto.Trim();
    }

    public bool EstaCompletamenteOculta()
    {
        foreach(Palavra palavra in _palavras)
        {
            if(palavra.EstaOculta() == false)
            {
                return false;
            }            
        }
        return true;
    }

    public string ObterReferencia()
    {
        return _referencia.ObterTexto();
    }
}