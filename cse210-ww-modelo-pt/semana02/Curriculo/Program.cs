using System;

class Program
{
    static void Main(string[] args)
    {   
        // instancia (objeto) da classe emprego
        Emprego emprego1 = new Emprego();
        emprego1._cargo = "Designer Gráfico";
        emprego1._empresa = "Gui Design Studio";
        emprego1._anoInicio = 2019;
        emprego1._anoFim = 2022;

        // instancia (objeto) da classe emprego
        Emprego emprego2 = new Emprego();
        emprego2._cargo = "Operador de Máquinas";
        emprego2._empresa = "Tecnoplaca";
        emprego2._anoInicio = 2022;
        emprego2._anoFim = 2023;

        // instancia (objeto) da classe curriculo
        Curriculo meuCurriculo = new Curriculo();
        meuCurriculo._nome = "Guilherme Saraiva";
        meuCurriculo._empregos.Add(emprego1);
        meuCurriculo._empregos.Add(emprego2);

        meuCurriculo.Exibir();
    }
}