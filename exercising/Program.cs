void Apresentacao() {
    // numero que a maquina definir
    Random random = new Random();
    int numRandomMaquina = random.Next(1, 101);

    Console.WriteLine("\nAcerte o número que a máquina está pensando! (de 0 a 100)");

    for (int numTentativas = 7; numTentativas > 0; numTentativas--) {
        
        Console.WriteLine("Você tem "+ numTentativas + " tentativas !");
        Console.Write("\nDigite um numero: ");
        string escolha = Console.ReadLine()!;
        int numEscolhido = int.Parse(escolha);

        if (numRandomMaquina == numEscolhido) {
            Console.WriteLine("\nACERTOU !!");
            Console.WriteLine("O N° que a máquina tava pensando era: [" + numRandomMaquina + "]");
            break;
        } else if (numRandomMaquina > numEscolhido) {
            Console.WriteLine("\nO número da máquina é MAIOR");
        } else if (numRandomMaquina < numEscolhido) {
            Console.WriteLine("\nO número da máquina é MENOR");
        } else {
            Console.WriteLine("\nDigite um número valido (de 0 a 100)");
            numTentativas = numTentativas;
        }
    };
    Console.WriteLine("N° da máquina era: [" + numRandomMaquina + "]");

}

Apresentacao();