public class Mamifero : Animal{
    private string corPelo{get;set;}

    public Mamifero(string nome, string especie, string corPelo, string som):
        base(nome, 4, especie, som)
    {

        this.corPelo = corPelo;
    }

    public string GetCorPelo(){
        return corPelo;
    }

    public override string DescricaoLonga(){
        string texto = "";
        
        texto += base.DescricaoLonga() + " e tem pelo " + GetCorPelo() + "\n";
        
        return texto;
    }
}