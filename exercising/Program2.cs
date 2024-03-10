List<int> todosNumeros = new List<int>();

void CalculaNumerosEmLista() {
    Console.WriteLine("Calculo de todos números em uma lista");

    int teclaContinuacao;

    while (teclaContinuacao != 0) {
        AdicionaNumerosNaLista();
        Console.WriteLine(@"
            Tecle [ 0 ] para continuar adicionando números na lista
            Tecle [ 1 ] para parar o programa
        ");

    }
}

int AdicionaNumerosNaLista() {
        Console.Write("Digite qualquer número que você queira adicionar na lista: ");
        string numeroDigitado = Console.ReadLine()!;
        int numeroDigitadoInt = int.Parse(numeroDigitado);

        todosNumeros.Add(numeroDigitado);

        Console.WriteLine($"Lista montada: {todosNumeros}");
}

CalculaNumerosEmLista();