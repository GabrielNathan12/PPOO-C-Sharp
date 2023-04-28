public class Item{
    private string descricao;
    private int peso;

    public Item(string descricao, int peso){
        this.descricao = descricao;
        this.peso = peso;
    }
    public string GetDescricaoItem(){
        return descricao;
    }
    public int GetPeso(){
        return peso;
    }
}