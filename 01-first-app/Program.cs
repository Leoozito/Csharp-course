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
            Console.WriteLine("Você escolhe a opção " + opcaoEscolhidaNumerica);
            break;    
        case 4:
            Console.WriteLine("Você escolhe a opção " + opcaoEscolhidaNumerica);
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

void TituloDasOpcao(string textoTitulo) {
    int quantidadeLetras = textoTitulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*'); // adLeft() pede dois argumentos: a quantidade de caracteres a serem inseridos à esquerda e qual caractere será.
    Console.WriteLine(asteriscos);
    Console.WriteLine(textoTitulo);
    Console.WriteLine(asteriscos + "\n");
}

ExibirOpcoesDoMenu();