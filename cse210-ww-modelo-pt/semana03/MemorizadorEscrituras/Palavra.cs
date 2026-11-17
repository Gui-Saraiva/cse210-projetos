public class Palavra{
    // variaveis membro
    private string _texto;
    private bool _estaOculta;
    
    // construtor
    public Palavra(string texto)
    {
        _texto = texto;
    }

    // metodos
    public void Ocultar()
    {
        _estaOculta = true;
    }

    public void Exibir()
    {

    }

    public bool EstaOculta()
    {   
        return _estaOculta;
    }

    public string ObterTexto()
    {   
        string palavraVersiculo = ""; // acumulador de sublinhados de cada palavra

        if(_estaOculta == true)
        {
            for(int i = 0; i < _texto.Length; i++)
            {
                palavraVersiculo += "_";
            }
            return palavraVersiculo;
        }
        else
        {
            return _texto;
        }        
    }
}