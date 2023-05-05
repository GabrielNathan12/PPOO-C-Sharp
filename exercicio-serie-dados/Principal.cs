
public class Principal{
    public void Executar(){
        Controle c = new Controle();
        
        foreach(SerieDados s in c.GetSerieDados()){
            Console.WriteLine("Dados da Serie:" + s.GetIdentificadorSerie());
            for(int i = s.GetDiaInicial(); i < s.GetDiaFinal(); i++){
                Console.WriteLine("Dias: "+ i + " = " + s.GetDados(i) + "K(g)");
            }
        }
    }
}