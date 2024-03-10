List<string> bandasRegistradas = new List<string>();

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
    Console.WriteLine("************************************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("************************************\n");

    Console.Write("Digite o nome da banda que gostaria de registrar: ");
    string nomeBanda = Console.ReadLine()!;

    bandasRegistradas.Add(nomeBanda);
    Console.WriteLine($"Banda {nomeBanda} registrada com sucesso");
    Thread.Sleep(2000);
    ExibirOpcoesDoMenu();
    Console.Clear();
}

void ExibeBandasRegistradas() {
    Console.Clear();
    Console.WriteLine("************************************");
    Console.WriteLine("Exibindo todas bandas registradas");
    Console.WriteLine("************************************\n");

    foreach (string bandas in bandasRegistradas) {
        Console.WriteLine($"Banda: {bandas}");
    }

    Console.WriteLine("Clique qualquer tecla para voltar ao menu inicial");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();