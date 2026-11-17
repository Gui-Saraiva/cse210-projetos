using System.Collections.Generic;
public class Referencia
{
    // variaveis membro
    private string _livro;
    private int _capitulo;
    private int _versiculo;
    private int _ultimoVersiculo;

    // construtores
    public Referencia(string livro, int capitulo, int versiculo)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = versiculo;
    }

    public Referencia(string livro, int capitulo, int primeiroVersiculo, int ultimoVersiculo)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = primeiroVersiculo;
        _ultimoVersiculo = ultimoVersiculo;
    }

    // metodo
    public string ObterTexto()
    {   
        if(_ultimoVersiculo == 0)
        {
            string escritura = $"{_livro} {_capitulo}:{_versiculo}";
            return escritura;
        }
        else{
            string escritura = $"{_livro} {_capitulo}:{_versiculo}-{_ultimoVersiculo}";
            return escritura;
        }        
    }

    // getters e setters
    public void DefinirLivro(string livro)
    {
        _livro = livro;
    }

    public string ObterLivro()
    {
        return _livro;
    }

    public void DefinirCapitulo(int capitulo)
    {
        _capitulo = capitulo;
    }

    public int ObterCapitulo()
    {
        return _capitulo;
    }

    public void DefinirVersiculo(int versiculo)
    {
        _versiculo = versiculo;
    }

    public int ObterVersiculo()
    {
        return _versiculo;
    }

    public void DefinirUltimoVersiculo(int ultimoVersiculo)
    {
        _ultimoVersiculo = ultimoVersiculo;
    }

    public int ObterUltimoVersiculo()
    {
        return _ultimoVersiculo;
    }
}