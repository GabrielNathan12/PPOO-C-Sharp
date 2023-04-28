using System.Collections;

public class Maculado{
    private string nome{get;set;}
    private List<Item> mochila;

    public Maculado(string nome){
        this.nome = nome;
        mochila = new List<Item>();
    }

    public string GetNome(){
        return nome;
    }
    public void AddItem(Item item){
        mochila.Add(item);
    }

    public void RemoverItem(string nome){
        for(int i =0; i < mochila.Count;i++){
            if(mochila[i].GetDescricaoItem().Equals(nome)){
                mochila.RemoveAt(i);
            }
        }
    }
    public string ListarItens(){
        string texto = "";

        foreach(var i in mochila){
            texto = texto + i.GetDescricaoItem() + " ";
        }
        return texto;
    }
}