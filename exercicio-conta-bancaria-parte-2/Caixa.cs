using System.Collections;
public class Caixa{
    private List<Conta> contas;

    public Caixa(){
        contas = new List<Conta>();
    }

    private void menu(){
        Console.WriteLine("1- Criar Conta: ");
        Console.WriteLine("2- Consultar Saldos: ");
        Console.WriteLine("3- Depositar: ");
        Console.WriteLine("4- Sacar: ");
        Console.WriteLine("5- Rendimento: ");
        Console.WriteLine("6- Transferencia: ");
        Console.WriteLine("7- Listar Contas: ");
        Console.WriteLine("8- Remover Conta: ");
        Console.WriteLine("9- Sair: ");
    }

    public void executar_programa(){
        int opcao;

        do{
            menu();
            Console.WriteLine("\nDigite uma opcao: ");
            opcao = int.Parse(Console.ReadLine());
            executar_menu(opcao);
        }
        while(opcao != 9);
    }

    private void executar_menu(int opcao){
        switch(opcao){
            case 1:
                criarConta();
            break;
            case 2:
                consultarSaldo();
            break;
            case 3:
                depositar(getConta(), getValor());
            break;
            case 4:
                sacar(getConta() , getValor());
            break;
            case 5:
                rendimento(getConta());
            break;
            case 6:
                tranferir(getConta() , getConta(), getValor());
            break;
            case 7:
                consultarListas();
            break;
            case 8:
                removerConta(getConta());
            break;
            case 9:
                Console.WriteLine("Obrigado por utilizar nosso caixa");
            break;
            default:
                Console.WriteLine("Opcao invalida!!");
            break;

        }
        if(opcao != 9){
            Console.WriteLine("\nDigite ENTER para continuar!");
            string input = Console.ReadLine();   
        }

    }

    private void criarConta(){
        Console.WriteLine("Digite uma opcao: ");
        Console.WriteLine("1- Conta com Saldo e limite dados pelo usuario: ");
        Console.WriteLine("2- Conta com Saldo 0 e valor inicial: ");

        int opcao = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite seu CPF: ");
        string cpf = Console.ReadLine();

        Cliente c = new Cliente(nome, cpf);

        if(opcao == 1){
            Console.WriteLine("Digite o saldo: ");
            double saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o limite da Conta: ");
            double limite = double.Parse(Console.ReadLine());

            contas.Add(new Conta(c, saldo, limite));
        }
        else if(opcao == 2){
            Console.WriteLine("Digite o valor inicial: ");
            double valorIni = double.Parse(Console.ReadLine());
            contas.Add(new Conta(c, valorIni));
        }
        else{
            Console.WriteLine("Opcao invalida, tente novamente");
        }

    }
    private void consultarSaldo(){
        foreach(var c in contas){
            Console.WriteLine(c.GetNumConta() + " = " +c.GetSaldo());
        }
    }
    private void depositar(int numConta, double valor){
        foreach(var c in contas){
            if(c.GetNumConta() == numConta){
                c.deposito(valor);
            }
        }
    }
    private void sacar(int numConta, double valor){
        foreach(var c in contas){
            if(c.GetNumConta() == numConta){
                c.saque(valor);
            }
        }
    }
    private void rendimento(int numConta){
        Console.WriteLine("Digite o total de meses da conta: ");
        int tempo = int.Parse(Console.ReadLine());

        foreach(var c in contas){
            if(c.GetNumConta() == numConta){
                c.render(tempo);
                Console.WriteLine("Rendimento da conta: " + c.GetSaldo());
            }
        }
    }
    private void tranferir(int contaOri, int contaDest, double valor){
        foreach(var c in contas){
            if(c.GetNumConta() == contaOri){
                c.saque(valor);
            }
        }
        foreach(var c in contas){
            if(c.GetNumConta() == contaDest){
                c.deposito(valor);
            }
        }
    }
    private void consultarListas(){
        foreach(var c in contas){
            Console.WriteLine(c.ToString());
        }
    }
    private void removerConta(int numConta){
        for(int i = 0; i < contas.Count; i++){
            if(contas[i].GetNumConta() == numConta){
                if(contas[i].GetSaldo() > 0){
                    Console.WriteLine("Nao e possivel remover, ainda existe saldo na conta");

                }
                else if(contas[i].GetSaldo() < 0){
                    Console.WriteLine("Nao e possivel remover, conta nagativada");
                }
                else{
                    contas.RemoveAt(i);
                }
            }
        }
    }

    private int getConta(){
        Console.WriteLine("Digite o numero da Conta: ");
        int numConta = int.Parse(Console.ReadLine());
        return numConta;
    }
    private double getValor(){
        Console.WriteLine("Digite o valor: ");
        double valor = double.Parse(Console.ReadLine());
        return valor;
    }
}