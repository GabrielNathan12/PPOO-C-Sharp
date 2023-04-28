public class Comando{
    private string palavraComando;
    private string segundaPalavra;


    public Comando(string primeiraPalavra, string segundaPalavra){
        palavraComando = primeiraPalavra;
        this.segundaPalavra = segundaPalavra;
    }

    public string GetPalavraComando(){
        return palavraComando;
    }

    public string GetSegundaPalavra(){
        return segundaPalavra;
    }

    public bool eConhecido(){
        return (palavraComando == null);
    }

    public bool temSegundaPalavra(){
        return (segundaPalavra != null);
    }
}