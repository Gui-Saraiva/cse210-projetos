using System;
public class Fracao
{
    private int _numerador;
    private int _denominador;

    public Fracao()
    {
        _numerador = 1;
        _denominador = 1;
    }

    public Fracao(int numerador)
    {
        _numerador = numerador;
        _denominador = 1;
    }

    public Fracao(int numerador, int denominador)
    {
        _numerador = numerador;
        _denominador = denominador;
    }

    public void DefinirNumerador(int numerador) // setter do numerador
    {
        _numerador = numerador;
    }

    public int ObterNumerador() // getter do numerador
    {
        return _numerador;
    }

    public void DefinirDenominador(int denominador) // setter do denominador
    {
        _denominador = denominador;
    }

    public int ObterDenominador() // getter do denominador
    {
        return _denominador;
    }

    public string ObterFracaoEmTexto() // metodo ou função que faz o calculo e retora string
    {
        string texto = $"{_numerador}/{_denominador}";
        return texto;
    }

    public double ObterFracaoEmDecimal() // metodo ou função que faz o calculo e retorna double (num decimal)
    {
        return (double)_numerador / (double)_denominador;
    }
}