using System;

public class Cliente{
    private string nome{get;}
    private string cpf{get;}

    public Cliente(string nome, string cpf){
        this.cpf = cpf;
        this.nome = nome;
    }

    public string GetNome(){
        return nome;
    }
}