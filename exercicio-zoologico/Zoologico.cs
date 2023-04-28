using System.Collections;
public class Zoologico{
    private List<Animal> animais;

    public Zoologico(){
        animais = new List<Animal>();
    }
    public string AddAnimal(string nome, string info, int opcao){
        string texto = "";
        if(opcao == 1){    
            Leao l = new Leao(nome, info);
            animais.Add(l);
            texto = "Um leao adcionado\n";
        }
        else if(opcao == 2){
            Gorila g = new Gorila(nome, info);
            animais.Add(g);
            texto = "Um Gorila adcionado\n";
        }
        else if(opcao == 3){
            Arara a = new Arara(nome, info);
            animais.Add(a);
            texto = "Uma Arara adcionado\n";
        }
        else if(opcao == 4){
            Ema e = new Ema(nome, info);
            animais.Add(e);
            texto = "Uma Ema adcionado\n";
        }
        else{
            texto = "Opcao incorreta\n";
        }
        return texto;
    }

    public string DescricaoCompleta(){
        string texto = "";
        
        foreach(var a in animais){
            texto += a.DescricaoLonga();
        }
        return texto;
    }

    public string DescricaoResumida(){
        string texto = "";
        
        foreach(var i in animais){
            texto += i.DescricaoCurta();
        }
        return texto;
    }

    public string Buscar(string nome){
        foreach(var i in animais){
            if(i.GetNome().Equals(nome)){
                return i.DescricaoLonga();
            }
        }
        return "Animal nao encontrado\n";
    }
}