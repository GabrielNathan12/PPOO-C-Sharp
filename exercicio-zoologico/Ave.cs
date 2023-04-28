private class Ave : Animal{
    private string infoVoo;

    public Ave(string nome, string especie, string infoVoo, string som):
    base(nome, 2, especie, som)
    {
        this.infoVoo = infoVoo;
    }

    public string GetInfoVoo(){
        return infoVoo;
    }

    public override string DescricaoLonga(){
        string texto = "";
        texto += base.DescricaoLonga() + " e voa " + GetInfoVoo() + "\n";
        return texto;
    }
}