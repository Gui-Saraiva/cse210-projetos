using System;
using System.Formats.Asn1;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        string opcao = Entrada.ReceberEntrada();
        OpcaoDesejada executar = new OpcaoDesejada(opcao);
    }
}