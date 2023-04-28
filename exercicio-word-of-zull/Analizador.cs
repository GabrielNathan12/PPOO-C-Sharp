using System.Collections;

public class Analizador{
    private PalavraComando pc;

    public Analizador(){
        pc = new PalavraComando();
    }

    public Comando pegarComando(){
        string linha;
        string palavra1 = null;
        string palavra2 = null;

        Console.Write("> ");

        linha = Console.ReadLine();
        string[] palavras = linha.Trim().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        if(palavras.Length >= 1){
            palavra1 = palavras[0];
        }
        if(palavras.Length >= 2){
            palavra2 = palavras[1];
        }

        if(pc.eComando(palavra1)){
            return new Comando(palavra1, palavra2);
        }
        else{
            return new Comando(null, palavra2);
        }

    }

    public string GetComandos(){
        return PalavraComando.GetComandos();
    }

}