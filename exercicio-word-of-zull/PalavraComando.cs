public class PalavraComando{
    private static readonly string[] comandosValidos ={
        "ir", "sair", "ajuda", "observar" , "pegar", "inventario"
    };

    public static string GetComandos(){
        string texto = "";

        foreach(var c in comandosValidos){
            texto = texto + c + " ";
        }
        return texto;
    }

    public bool eComando(string palavra){

        for(int i=0; i < comandosValidos.Length; i++){
            if(comandosValidos[i].Equals(palavra)){
                return true;
            }
        }
        return false;
    }
}