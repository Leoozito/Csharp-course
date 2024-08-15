public class Produto
{
    public string? nome; 
    public string? marca; 
    private double _preco;

    private int _estoque;

    public double Preco { 
        get => _preco;
        set 
        {
            if (value > 0) {
                _preco = value;
            } else {
                throw new ArgumentException("Estoque não informado");
            }
        }
    }

    public int Estoque { 
        get => _estoque;
        set 
        {
            if (value > 0) {
                _estoque = value;
            } else {
                throw new ArgumentException("Estoque não informado");
            }
        }
    }

    private string DescricaoResumida => @$"

O produto {nome} da marca {marca}
Preço: R$ {_preco}
Tem disponivel em seu ESTOQUE : {_estoque}

    ";

    public void ExibeDetalhesDoProduto() {
        Console.WriteLine(DescricaoResumida);
    }
}