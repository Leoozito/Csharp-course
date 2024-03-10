# Algumas anotações

> Comando para criar um projeto em C#
```dotnet new console```
> Comando para iniciar
```dotnet run Program.cs```

### Lista e Dicionario

```cs
    List<string> bandasRegistradas = new List<string>();

    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda); // adicionando elemento na lista

    foreach (string bandas in bandasRegistradas) {
        Console.WriteLine($"Banda: {bandas}");
    }
```

```cs
    Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
    
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>()); // adicionando elemento no dicionário

    foreach (string bandas in bandasRegistradas.Keys) { 
        Console.WriteLine($"Banda: {bandas}");
    }
```
