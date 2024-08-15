List<int> todosNumeros = new List<int>();

void CalculaNumerosEmLista() {
    Console.WriteLine("\n************************************");
    Console.WriteLine("Calculo de números em uma lista");
    Console.WriteLine("************************************\n");

    int teclaContinuacao = 1;

    while (teclaContinuacao == 1) {
        AdicionaNumerosNaLista();
        Console.WriteLine(@"
Tecle [ 1 ] para AUMENTAR a lista !
Tecle [ 2 ] para PARAR e VER O RESULTADO do calculo !
        ");

        string tecla = Console.ReadLine()!;
        teclaContinuacao = int.Parse(tecla);

        if (teclaContinuacao == 2) {
            RetornaCalculoSoma(todosNumeros);
        }
    }
}

void AdicionaNumerosNaLista() {
    Console.Write("Digite qualquer número que você queira adicionar na lista: ");
    string numeroDigitado = Console.ReadLine()!;
    int numeroDigitadoInt = int.Parse(numeroDigitado);

    todosNumeros.Add(numeroDigitadoInt);

    Console.WriteLine($"Lista montada: {string.Join(", ", todosNumeros)}");
}

void RetornaCalculoSoma(List<int> todosNumeros) {
    int valorTotalNumeros = 0;

    foreach (int cadaNumero in todosNumeros) {
        valorTotalNumeros += cadaNumero;
    }

    Console.Clear();
    Console.WriteLine($"Sua lista: {string.Join(", ", todosNumeros)}");
    Console.WriteLine($"Soma de todos os numeros da lista: {valorTotalNumeros}");
}

CalculaNumerosEmLista();