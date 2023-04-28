public class InterfaceUsuario{
    private Zoologico zoologico;

    public InterfaceUsuario(){
        zoologico = new Zoologico();
    }

    public void Executar(){
        int opcao;
        
        do{
            ExibirMenu();
            Console.WriteLine("\nDigite uma opcao: ");
            opcao = int.Parse(Console.ReadLine());
            TratarMenu(opcao);
        }while(opcao != 5);
    }

    private void ExibirMenu(){

    }
    private void TratarMenu(int opcao){
        
    }
}