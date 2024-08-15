class Carro
{
	public string? fabricante;
	public string? modelo;

	private int _ano;
	public int Ano 
	{ 
		get {
			return Ano;
		} 
		set 
		{
			if ((value >= 1960) && (value <= 2000)) {
				_ano = value;
			}
		} 
	}
	private string DescricaoDetalhada => $"O modelo {modelo} do ano {_ano} fabricado pela {fabricante} est� sendo um sucesso!";

	public void ExibeMenu() {
		Console.WriteLine($"---- Descrição detalhada: {DescricaoDetalhada} ----");
	}
}



