using System.Collections.Generic;
public class BibliotecaEscrituras
{
    private List<Escritura> _escrituras = new List<Escritura>();

    public BibliotecaEscrituras()
    {
        Referencia referencia = new Referencia("1 Néfi", 3, 7);
        Escritura escritura = new Escritura(referencia, "E aconteceu que eu, Néfi, disse a meu pai: Eu irei e cumprirei as ordens do Senhor, porque sei que o Senhor nunca dá ordens aos filhos dos homens sem antes preparar um caminho pelo qual suas ordens possam ser cumpridas.");
        _escrituras.Add(escritura);

        Referencia referencia2 = new Referencia("2 Néfi", 32, 8, 9);
        Escritura escritura2 = new Escritura(referencia2, "E agora, meus amados irmãos, percebo que ainda meditais em vosso coração; e é-me doloroso falar-vos sobre isso. Porque, se désseis ouvidos ao Espírito que ensina o homem a orar, saberíeis que deveis orar; porque o espírito mau não ensina o homem a orar, mas ensina-lhe que não deve orar. Mas eis que vos digo que deveis orar sempre e não desfalecer; e nada deveis fazer para o Senhor sem antes orar ao Pai, em nome de Cristo, para que ele consagre para vós a vossa ação, a fim de que a vossa ação seja para o bem-estar de vossa alma.");
        _escrituras.Add(escritura2);

        Referencia referencia3 = new Referencia("Mosias", 2, 17);
        Escritura escritura3 = new Escritura(referencia3, "E eis que vos digo estas coisas para que aprendais sabedoria; para que saibais que, quando estais a serviço de vosso próximo, estais somente a serviço de vosso Deus.");
        _escrituras.Add(escritura3);
    }

    public Escritura Sorteio()
    {
        Random escrituraSorteada = new Random();
        int sorteada = escrituraSorteada.Next(_escrituras.Count);

        return _escrituras[sorteada];
    }
}