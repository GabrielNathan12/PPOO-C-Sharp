public class Cliente{
    private string nome{get;set;}
    private string cpf{get;set;}

    public Cliente(string nome, string cpf){
        this.cpf = cpf;
        this.nome = nome;
    }

    public string GetNome(){
        return nome;
    }
}