public class Controle{
    private List<SerieDados> sd;

    public Controle(){
        sd = new List<SerieDados>();
        SerieDadosPetShop petShop = new SerieDadosPetShop("gato", 1, 5);
        petShop.AddDados(1,2);
        petShop.AddDados(2,7);
        petShop.AddDados(3,17);
        petShop.AddDados(4,10);
        petShop.AddDados(5,13);

        SerieDadosPetShop petShop1 = new SerieDadosPetShop("cao", 1,4);
        petShop1.AddDados(1,15);
        petShop1.AddDados(2,5);
        petShop1.AddDados(3,30);
        petShop1.AddDados(4,18);

        sd.Add(petShop);
        sd.Add(petShop1);
    }
    public List<SerieDados> GetSerieDados(){
        return sd;
    }
}
