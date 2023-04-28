using System.Collections;

public class Ambiente{
    private string descricao;
    private Dictionary<string, Ambiente> saida;
    private Item item;

    public Ambiente(string descricao){
        this.descricao = descricao;
        saida = new Dictionary<string, Ambiente>();
    }
    public Ambiente(string descricao, Item item):this(descricao){
        this.item = item;
    }

    public Ambiente GetAmbiente(string direcao){
        return saida[direcao];
    }

    public Ambiente GetSaida(string descricao){
        return saida[descricao];
    }

    public void AjustarSaidas(string direcao, Ambiente ambiente){
        saida.Add(direcao, ambiente);
    }
    public string GetDescricao(){
        return descricao;
    }

    public string GetDescricaoLonga(){
        string texto = descricao + "\n" + GetSaidas();

        if(item != null && AchouItem()){
            texto = "Existem um item " + item.GetDescricaoItem();
        }
        else{
            return "Nao existe nada aqui";
        }
        return texto;

    }
    public string GetSaidas(){
        string texto = "";
        
        foreach(var i in saida.Keys){
            texto = texto + i + " ";
        }

        return texto;
    }
    public Item ConsultarIntem(){
        if(item == null){
            return null;
        }
        else{
            return item;
        }
    }
    public bool AchouItem(){
        if(item == null){
            return false;
        }
        else{
            return true;
        }
    }

    public Item ColetarItem(){
        Item aux = item;
        item = null;

        return aux;
    }
}