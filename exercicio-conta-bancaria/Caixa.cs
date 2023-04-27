
public class Caixa{
    private Conta conta1;
    private Conta conta2;

    
    public void menu(){
        Console.WriteLine("1- Criar Conta: ");
        Console.WriteLine("2- Consultar Saldo: ");
        Console.WriteLine("3- Deposicar: ");
        Console.WriteLine("4- Sacar: ");
        Console.WriteLine("5- Rendimento: ");
        Console.WriteLine("6- Transferencia: ");
        Console.WriteLine("7- Sair do programa");
    }

    public void executar_programa(){
        int opcao;
        
        do{
            menu();
            Console.WriteLine("\nDigite uma opcao: ");

            opcao = int.Parse(Console.ReadLine());
            executar_menu(opcao);
            
        }while(opcao != 7);
    }

    public void executar_menu(int opcao){
        switch(opcao){
            case 1: 
                criar_conta();
            break;
            case 2:
                consultar_saldo();
            break;
            case 3:
                depositar(getConta(), getValor());
            break;
            case 4:
                sacar(getConta(), getValor());
            break;
            case 5:
                rendimento();
            break;
            case 6:
                transferencia(getConta(), getConta(), getValor());
            break;
            case 7:
                Console.WriteLine("Obrigado por utilizar nosso programa");
            break;
            default:
                Console.WriteLine("Opcao invalida!! \n tente novamente");
            break;
        }

        if(opcao != 7){
            Console.WriteLine("\n" + "Digite ENTER para continuar!");
            string input = Console.ReadLine();
        }
    }

    public void criar_conta(){
        Console.WriteLine("Digite os dados da primeira conta:\n");
        string nome;
        string cpf;

        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Digite seu CPF: ");
        cpf = Console.ReadLine();

        Cliente c1 = new Cliente(nome , cpf);

        Console.WriteLine("\nDigite os dados da segunda conta: ");
        
        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Digite seu CPF: ");
        cpf = Console.ReadLine();

        Cliente c2 = new Cliente(nome , cpf);

        Console.WriteLine("\nEscolhar uma das opcoes: ");
        Console.WriteLine("\n1- Criar conta normal: ");
        Console.WriteLine("\n2-Criar conta com valor inicial: ");

        int opcao = int.Parse(Console.ReadLine());
        double valorInicial;


        if(opcao == 1){
            conta1 = new Conta(c1, 100.0, -100.0);
            conta2 = new Conta(c2, 3000, -4000);
        }
        else if(opcao == 2){
            Console.WriteLine("Digite o valor inicial da primeira conta: \n");
            valorInicial = double.Parse(Console.ReadLine());
            conta1 = new Conta(c1, valorInicial);
            Console.WriteLine("Digite o valor inicial da segunda conta: \n");
            valorInicial = double.Parse(Console.ReadLine());
            conta2 = new Conta(c2, valorInicial);
        }
        else{
            Console.WriteLine("Opcao Invalida!! \nTente Novamente");
        }
    }
    public void consultar_saldo(){
        Console.WriteLine(conta1.ToString());
        Console.WriteLine(conta2.ToString());
    }
    public int getConta(){
        Console.WriteLine("Digite o numero da Conta: ");
        int numConta = int.Parse(Console.ReadLine());
        return numConta;
    }
    public double getValor(){
        Console.WriteLine("Digite o valor: ");
        double valor = double.Parse(Console.ReadLine());
        return valor;
    }

    public void depositar(int numConta, double valor){
       if(numConta == conta1.GetNumConta()){
            conta1.deposito(valor);
       }
       else if(numConta == conta2.GetNumConta()){
            conta2.deposito(valor);
       }
        else{
            Console.WriteLine("Conta inexistente");
       }
    }

    public void sacar(int numConta, double valor){
       if(numConta == conta1.GetNumConta()){
            conta1.saque(valor);
       }
       else if(numConta == conta2.GetNumConta()){
            conta2.saque(valor);
       }
        else{
            Console.WriteLine("Conta inexistente");
       }
    }
    public void rendimento(){
        Console.WriteLine("Digite o total de meses da conta 1: ");
        int tempo = int.Parse(Console.ReadLine());
        conta1.render(tempo);
        Console.WriteLine("Digite o total de meses da conta 2: ");
        tempo = int.Parse(Console.ReadLine());
        conta2.render(tempo);

        Console.WriteLine("Rendimento da conta 1: " + conta1.GetSaldo() + "\nRendimento da conta 2: " + conta2.GetSaldo());
    }

    public void transferencia(int contaOri, int contaDest, double valor){
        if(conta1.GetNumConta() == contaOri && conta2.GetNumConta() == contaDest){
            conta1.saque(valor);
            conta2.deposito(valor);
        }
        else if(conta2.GetNumConta() == contaOri && conta1.GetNumConta() == contaDest){
            conta2.saque(valor);
            conta1.deposito(valor);
        }
        else{
            Console.WriteLine("Conta inexistente! \n Tente novamente");
        }
    }
}