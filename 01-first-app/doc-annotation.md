# Algumas anotações

> Comando para criar um projeto em C#
```dotnet new console```
> Comando para iniciar
```dotnet run Program.cs```

## Lista (detalhes)

```cs
    List<string> bandasRegistradas = new List<string>();

    string nomeBanda = Console.ReadLine()!;
    bandasRegistrad as.Add(nomeBanda); // adicionando elemento na lista

    foreach (string bandas in bandasRegistradas) { // utilizando o foreach para acessar cada dado contido na lista
        Console.WriteLine($"Banda: {bandas}");
    }

```

## Dicionario (detalhes)

```cs
    Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
    
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>()); // adicionando elemento no dicionário

    foreach (string bandas in bandasRegistradas.Keys) { // utilizando o foreach para acessar cada dado contido no dicionario
        Console.WriteLine($"Banda: {bandas}");
    }

    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda)) { // verificação de se há determinado dado dentro do dicionario

        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota); // adicionando valor a uma determinada parte do dicionario
    }
```

> .Average para calcular média, .Value pega os valores

```cs
    var notasAlunos = new Dictionary<string, Dictionary<string, List<int>>> {
        { "Ana", new Dictionary<string, List<int>> {
            { "C#", new List<int> { 8, 7, 6 } },
        }},
    }
    
    foreach (var alunos in notasAlunos.Keys) {
        Dictionary<string, List<int>> notas = notasAlunos[alunos];
        foreach (var materia in notas) {
            List<int> notasDaMateria = materia.Value;
            double media = notasDaMateria.Average();
        }
    }
```
