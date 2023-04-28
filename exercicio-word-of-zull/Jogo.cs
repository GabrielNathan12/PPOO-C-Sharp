public class Jogo{
    private Analizador analizador;
    private Ambiente ambiente;
    private Maculado jogador;

    public Jogo(){
        CriarAmbiente();
        analizador = new Analizador();
        jogador = new Maculado("Jogador_1");
    }
    private void CriarAmbiente(){
        Ambiente lingrave, caelid, platus, montanha, mansao, rio;

        lingrave = new Ambiente("em um espaco aberto, em lingrave, a frente esta Platus Altos ");
        caelid = new Ambiente("em Caelid");
        platus = new Ambiente("em Platus Altos");
        montanha = new Ambiente("na Montanha dos Gigantes");
        mansao = new Ambiente("na Mansao Vulcanica" , new Item("carta", 0));
        rio = new Ambiente("no Rio Siofra", new Item("chave" , 1));

        lingrave.AjustarSaidas("norte", platus);
        lingrave.AjustarSaidas("leste", caelid);
        lingrave.AjustarSaidas("baixo", rio);

        caelid.AjustarSaidas("leste", lingrave);

        rio.AjustarSaidas("cima", lingrave);

        platus.AjustarSaidas("oeste", mansao);
        platus.AjustarSaidas("leste", montanha);
        platus.AjustarSaidas("sul", lingrave);

        montanha.AjustarSaidas("oeste", platus);
        mansao.AjustarSaidas("leste", platus);

        ambiente = lingrave;

    }

    private void ImprimirBoasVindas(){
        Console.WriteLine("\nBem-Vindo ao Elder Ring!");
        Console.WriteLine("Elder Ring e um novo jogo de aventura, incrivel.");
        Console.WriteLine("Digite 'ajuda' se voce precisar de ajuda\n");
        ImprimirLocalizacaoAtual();
    }

    private void ImprimirLocalizacaoAtual(){
        Console.WriteLine("Voce esta em " + ambiente.GetDescricao());
        Console.WriteLine("Saidas: ");
        Console.WriteLine(ambiente.GetSaidas() + "\n");
    }

    public void Observar(Comando comando){
        ImprimirLocalizacaoAtual();
        Console.WriteLine(ambiente.GetDescricaoLonga());
    }

    private bool ProcessarComando(Comando comando){
        bool sair = false;

        if(comando.eConhecido()){
            Console.WriteLine("Eu nao entendi o que vc disse ...");
            return false;
        }
        string palavraComando = comando.GetPalavraComando();

        if(palavraComando.Equals("ajuda")){
            ImprimirAjuda();
        }
        else if(palavraComando.Equals("ir")){
            IrParaAmbiente(comando);
        }
        else if(palavraComando.Equals("sair")){
            sair = Sair(comando);
        }
        else if(palavraComando.Equals("observar")){
            Observar(comando);
        }
        else if(palavraComando.Equals("pegar")){
            PegarItem(comando);
        }
        else if(palavraComando.Equals("inventario")){
            ExibirItens(comando);
        }
        return sair;
    }

    private void PegarItem(Comando comando){
        if(!comando.temSegundaPalavra()){
            Console.WriteLine("Pegar o que ? ");
            return;
        }
        else{
            if(ambiente.AchouItem()){
                jogador.AddItem(ambiente.ColetarItem());
                ambiente.ConsultarIntem();
                Console.WriteLine("Item coletado");
            }
            else{
                Console.WriteLine("Comando invalido");
            }
        }
    }
    private void ExibirItens(Comando comando){
        Console.WriteLine("Itens no seu Invetario: ");
        Console.WriteLine(jogador.ListarItens());
    }
    private bool Sair(Comando comando){
        if(comando.temSegundaPalavra()){
            Console.WriteLine("Sair o que ? ");
            return false;
        }else{
            return true;
        }
        
    }
    private void IrParaAmbiente(Comando comando){
        if(!comando.temSegundaPalavra()){
            Console.WriteLine("Ir para onde ?");
            return;
        }
        string direcao = comando.GetSegundaPalavra();

        Ambiente proximoAmbiente = null;
        proximoAmbiente = ambiente.GetAmbiente(direcao);

        if(proximoAmbiente == null){
            Console.WriteLine("Nao a passagem");
        }
        else{
            ambiente = proximoAmbiente;
            ImprimirLocalizacaoAtual();
        }
    }
    private void ImprimirAjuda(){
        Console.WriteLine("Voce esta perdido. Nao sabe qual caminho percorrer a partir daqui. Voce caminha");
        Console.WriteLine("pelo mapa de Elder Ring\n");
        Console.WriteLine("Suas palavras de comando sao: ");
        Console.WriteLine(" " + analizador.GetComandos());
    }


    public void Jogar(){
        ImprimirBoasVindas();
        bool terminado = false;

        while(!terminado){
            Comando comando = analizador.pegarComando();
            terminado = ProcessarComando(comando);
        }
        Console.WriteLine("Obrigado por jogar, Ate mais!");
    }

}