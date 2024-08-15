class ContaBancaria {
    public int id;
    public string titular;
    public double saldo;
    public string senha = "121212";

    public void ExibeDadosConta() {
        Console.Write("Digite sua senha: ");
        string senhaDigitada = Console.ReadLine()!;
        if (senhaDigitada == senha) {
            Console.WriteLine("------------------");
            Console.WriteLine("Dados bancários");
            Console.WriteLine("------------------");

            Console.WriteLine($"ID da Conta: {id}");
            Console.WriteLine($"Titular: {titular}");
            Console.WriteLine($"Saldo: {saldo}");
        } else {
            Console.WriteLine("Senha incorreta, tente novamente mais tarde");
        }
    }
}