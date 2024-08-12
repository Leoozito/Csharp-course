class Conta
{
    public int id { get; set; } = 2000;
    public string titular { get; set; } = "LEONARDO";
    public int saldo { get; set; } = 2000;
        
    public void exibeMenu()
    {
        Console.WriteLine($"ID USUARIO {id}");
	    Console.WriteLine($"TITULAR: {titular}");
	    Console.WriteLine($"SALDO: {saldo}");
	}

    public void saque(int valorSacar)
    {
	    if (valorSacar > saldo)
	    {
            Console.WriteLine("Saldo insuficiente");
	    } else
        {
            saldo -= valorSacar;
            Console.WriteLine($"Seu saldo: {saldo}");
        }
    }

    public void recebimento(int valorDepositado)
    {
        saldo += valorDepositado;
        Console.WriteLine("Valor Depositado");
        exibeMenu();
    }
}

