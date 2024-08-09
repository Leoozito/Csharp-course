class Musica {
    public string Nome { get; set; }
    public string Artista { get; set; }
    public double Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A musica {Nome} pertence a banda {Artista}";

    public void ExibirFichaTecnica() {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"{DescricaoResumida}");
       
        if (Disponivel) 
        {
            Console.WriteLine("Disponível no plano.\n");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+\n");
        }
    }
}