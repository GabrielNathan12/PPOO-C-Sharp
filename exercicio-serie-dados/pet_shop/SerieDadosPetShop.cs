public class SerieDadosPetShop : SerieDados{
    private string ID;
    private int diaInicial;
    private int diaFinal;
    private Dictionary<int, int> dados;

    public SerieDadosPetShop(string id, int diaInicial, int diaFinal){
        this.ID = id;
        this.diaInicial = diaInicial;
        this.diaFinal = diaFinal;
        dados = new Dictionary<int, int>();
    }

    public bool AddDados(int dia, int peso){
        if(dia >= GetDiaInicial() && dia <= GetDiaFinal()){
            if(!dados.ContainsKey(dia)){
                dados.Add(dia,peso);
                return true;
            }
        }
        return false;
    }
    public int GetDiaInicial(){
        return diaInicial;
    }
    public int GetDiaFinal(){
        return diaFinal;
    }
    public string GetIdentificadorSerie(){
        return ID;
    }
    public int GetDados(int dia){
        if(dia >= GetDiaInicial() && dia <= GetDiaFinal()){
            foreach(var i in dados.Keys){
                if(i == dia){
                    return dados[i];
                }
            }
        }
        return 0;
    }
}
