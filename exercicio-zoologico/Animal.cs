public class Animal{
    private string nome{get;set;}
    private int qtdPatas{get;set;}
    private string som{get;set;}
    private string especie{get;set;}
    public Animal(string nome, int qtdPatas, string especie, string som){
        this.nome = nome;
        this.qtdPatas = qtdPatas;
        this.especie = especie;
        this.som = som;

    }

    public string GetNome(){
        return nome;
    }
    public int GetQtdPatas(){
        return qtdPatas;
    }
    public string GetSom(){
        return som;
    }
    public string GetEspecie(){
        return especie;
    }
    public string DescricaoLonga(){
        string texto = "";
        texto += nome + " e um(a) " + especie + " que faz " + som;
        return texto;
    }
    public string DescricaoCurta(){
        string texto = "";
        texto += nome + " e um(a) " + especie + "\n";
        return texto;
    }
}
