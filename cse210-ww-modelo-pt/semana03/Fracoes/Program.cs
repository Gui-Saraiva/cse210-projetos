using System;

class Program
{
    static void Main(string[] args)
    {
        Fracao f1 = new Fracao(); // cria o obj da classe e usa o primeiro construtor sem parametros
        f1.DefinirNumerador(1); // altera a variavel privada do numerador pelo setter (porem aqui manteve o mesmo valor do construtor)
        f1.DefinirDenominador(1); // altera a variavel privada do denominador pelo setter (porem aqui manteve o mesmo valor do construtor)
        Console.WriteLine(f1.ObterFracaoEmTexto()); // chama o metodo que faz o calculo e retorna string
        Console.WriteLine(f1.ObterFracaoEmDecimal()); // chama o metodo que faz o calculo e retorna numero decimal

        Fracao f2 = new Fracao(5); // cria o obj da classe e usa o segundo construtor com 1 parametro
        f2.DefinirNumerador(5); // setter para definir o numerador; mas mantém o valor do construtor
        Console.WriteLine(f2.ObterFracaoEmTexto()); // chama o metodo que faz o calculo e retorna string
        Console.WriteLine(f2.ObterFracaoEmDecimal()); // chama o metodo que faz o calculo e retorna numero decimal

        Fracao f3 = new Fracao(3, 4); // cria o obj da classe e usa o terceiro construtor com 2 parametros
        f3.DefinirNumerador(3); // setter para definir o numerador; mas mantém o valor do construtor
        f3.DefinirDenominador(4); // setter para definir o numerador; mas mantém o valor do construtor
        Console.WriteLine(f3.ObterFracaoEmTexto()); // chama o metodo que faz o calculo e retorna string
        Console.WriteLine(f3.ObterFracaoEmDecimal()); // chama o metodo que faz o calculo e retorna numero decimal

        Fracao f4 = new Fracao(1, 3); // cria o obj da classe e usa o terceiro construtor com 2 parametros
        f4.DefinirNumerador(1); // setter para definir o numerador; mas mantém o valor do construtor
        f4.DefinirDenominador(3); // setter para definir o numerador; mas mantém o valor do construtor
        Console.WriteLine(f4.ObterFracaoEmTexto()); // chama o metodo que faz o calculo e retorna string
        Console.WriteLine(f4.ObterFracaoEmDecimal()); // chama o metodo que faz o calculo e retorna numero decimal
    }
}