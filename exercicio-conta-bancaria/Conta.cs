public class Conta{
    private double limite{get; set;}
    private double saldo{get;  set;}
    private Cliente c;
    private int numConta{get;  set;}
    private double valorInicial{get;  set;}
    private static int ultimaConta = 100;
    private static double percentual;

    public Conta(Cliente c, double saldo, double limite){
        this.c = c;
        this.saldo = saldo;
        this.limite = limite;
        percentual = 0.08;
        ultimaConta++;
        numConta = ultimaConta;
    }

    public Conta(Cliente c, double valorInicial){
        this.c = c;
        this.saldo = saldo;
        this.valorInicial = valorInicial;
        limite = 0.0;
        percentual = 0.06;
        ultimaConta++;
        numConta = ultimaConta;

    }
   
    public int GetNumConta(){
        return numConta;
    }

    public double GetSaldo(){
        return saldo;
    }
    public void saque(double valor){
        if(saldo <= limite){
            Console.WriteLine("Saldo insuficiente: ");

        }else{
            saldo -= valor;
        }
    }
    public void deposito(double valor){
        saldo += valor;
    }
    public void render(int tempo){
        saldo *= percentual + tempo;
    }

    public override string ToString(){
        return $"{c.GetNome()}: \nSaldo: {saldo} \nNumero da Conta: {numConta} \n";
    }
}