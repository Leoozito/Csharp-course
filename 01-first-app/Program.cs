// List<string> bandasRegistradas = new List<string>();
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

bandasRegistradas.Add("Linkin Park", new List<int> {10, 8, 6});
bandasRegistradas.Add("The Beatles", new List<int> ());

void ExibirMensagemDeBoasVindas() {
    Console.WriteLine(@"

    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝

    ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░

    ");
    Console.WriteLine("Seja bem vindo ao Screen Sound");
}

void ExibirOpcoesDoMenu() {
    ExibirMensagemDeBoasVindas();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica) {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ExibeBandasRegistradas();
            break;
        case 3:
            AvaliarBandas();
            break;    
        case 4:
            MediaDasBandas();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default: 
            Console.WriteLine("Opção invalida!");
            break;
    }
}

void RegistrarBanda() {
    Console.Clear();
    TituloDasOpcao("Registro das bandas");

    Console.Write("Digite o nome da banda que gostaria de registrar: ");
    string nomeBanda = Console.ReadLine()!;

    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"Banda {nomeBanda} registrada com sucesso");
    Thread.Sleep(2000);
    ExibirOpcoesDoMenu();
    Console.Clear();
}

void ExibeBandasRegistradas() {
    Console.Clear();
    TituloDasOpcao("Exibindo todas bandas registradas");

    foreach (string bandas in bandasRegistradas.Keys) { // .Keys para o foreach acessar um dicionario
        Console.WriteLine($"Banda: {bandas}");
    }

    Console.WriteLine("Clique qualquer tecla para voltar ao menu inicial");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarBandas() {
    Console.Clear();
    TituloDasOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda)) { // se a banda que o usuario digitou tiver na lista
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void MediaDasBandas() {
    Console.Clear();
    TituloDasOpcao("Media de avaliação das bandas");

    Console.WriteLine(@"
VOCÊ GOSTARIA DE:

[0] Ver a media de todas as bandas
[1] Ver a media de uma banda especifica
    ");

    int tecla = int.Parse(Console.ReadLine()!);

    if (tecla == 0) {
        ExibeMediaTodasBandas();
    } else if (tecla == 1) {
        ExibeMediaUmaBanda();
    } else {
        Console.WriteLine("Opção invalida!");
        Thread.Sleep(2000);
        MediaDasBandas();
    }
}

void ExibeMediaTodasBandas() {
    foreach (var banda in bandasRegistradas.Keys) {
        List<int> bandas = bandasRegistradas[banda];
        Console.WriteLine($"\nBanda: {banda} | Média: {bandas.Average()}");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
    }
}

void ExibeMediaUmaBanda() {
    Console.Write("Digite o nome da banda que deseja ver a média: ");
    string bandaDesejada = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(bandaDesejada)) {
        List<int> media = bandasRegistradas[bandaDesejada];
        Console.WriteLine($"\nBanda desejada: {bandaDesejada} | Média: {media.Average()}");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
    } else {
        Console.Clear();
        Console.WriteLine($"\nBanda {bandaDesejada} não encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
    }
}

void TituloDasOpcao(string textoTitulo) {
    int quantidadeLetras = textoTitulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*'); // adLeft() pede dois argumentos: a quantidade de caracteres a serem inseridos à esquerda e qual caractere será.
    Console.WriteLine(asteriscos);
    Console.WriteLine(textoTitulo);
    Console.WriteLine(asteriscos + "\n");
}

ExibirOpcoesDoMenu();