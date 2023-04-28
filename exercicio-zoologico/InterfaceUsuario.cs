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
        Console.WriteLine("1- Cadastrar animal ");
        Console.WriteLine("2- Descrever animal ");
        Console.WriteLine("3- Listar animais ");
        Console.WriteLine("4- Listar todos os animais ");
        Console.WriteLine("5- Sair ");
    }
    private void TratarMenu(int opcao){
        switch (opcao){
            case 1:
                CadastrarAnimal();
            break;
            case 2:
                DescreverAnimal();
            break;
            case 3:
                ListarAnimais();
            break;
            case 4:
                ListarAnimaisCompleto();
            break;
            case 5:
                Console.WriteLine("Obrigado por utilizar \nSaindo do programa...");
            break;
            default:
                Console.WriteLine("Opcao invalida \nTente Novamente");
            break;
        }

        if(opcao != 5){
            Console.WriteLine("\nDigite ENTER para continuar!");
            string input = Console.ReadLine();
        }
    }

    private void Listar(){
        Console.WriteLine("Escolhar uma opcao");
        Console.WriteLine("1- Leao");
        Console.WriteLine("2- Gorila");
        Console.WriteLine("3- Ema");
        Console.WriteLine("4- Arara");
    }
    private void CadastrarAnimal(){
        Listar();

        int opcao = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite a informacao");
        Console.WriteLine("Para Mamiferos sua cor de Pelo e para Aves se voa bem ou mal ");
        string info = Console.ReadLine();
        Console.WriteLine(zoologico.AddAnimal(nome, info, opcao));

    }
    private void DescreverAnimal(){
        Console.WriteLine("Digite o nome do animal");
        string nome = Console.ReadLine();
        Console.WriteLine(zoologico.Buscar(nome));
    }
    private void ListarAnimais(){
        Console.WriteLine(zoologico.DescricaoResumida());
    }
    private void ListarAnimaisCompleto(){
        Console.WriteLine(zoologico.DescricaoCompleta());
    }
    
}