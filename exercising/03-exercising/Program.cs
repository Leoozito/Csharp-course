Conta conta = new Conta();

conta.exibeMenu();
string valorSacar = Console.ReadLine()!;
conta.saque(int.Parse(valorSacar));