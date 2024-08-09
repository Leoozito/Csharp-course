# Algumas anotações

## Lambdas C#

No C#, lambdas são funções anônimas que podem ser usadas para criar expressões ou blocos de código compactos e concisos.
Eles são especialmente úteis quando se trata de trabalhar com coleções de dados, realizar operações em uma sequência de elementos ou lidar com delegados.

> Uma variavel apenas com método GETTER é descrita com "=>".

```cs
    public int Idade = { get; set; };
    public string Nome => "Leonardo";
```

Outro exemplo (como separar apenas números pares) mais explicativo sobre lambda:

Codigo sem lambda:
```cs
List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

List<int> numerosPares = numeros.FindAll(BuscarNumerosQueSaoPares);

bool BuscarNumerosQueSaoPares(int numero)
{
    return numero % 2 == 0;
}

foreach (int numero in numerosPares)
{
    Console.WriteLine(numero);
}
```

Codigo com lambda:
```cs
List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);

numerosPares.ForEach(numero => Console.WriteLine(numero));
```

É basicamente :

```
(parametros) => expressao
```

> Ou seja, é passado parametro, para uma expressão realizar a logica,

#### Quando usar lambda?: 

As lambdas podem ser usadas em várias situações, como filtrar, ordenar, mapear ou reduzir coleções de dados.