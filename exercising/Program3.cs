var notasAlunos = new Dictionary<string, Dictionary<string, List<int>>> {
    { "Ana", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 8, 7, 6 } },
        { "Java", new List<int> { 7, 6, 5 } },
        { "Python", new List<int> { 9, 8, 8 } }
    }},
    { "Maria", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 6, 5, 4 } },
        { "Java", new List<int> { 8, 7, 6 } },
        { "Python", new List<int> { 6, 10, 5 } }
    }},
    { "Luiza", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 2, 3, 10 } },
        { "Java", new List<int> { 8, 8, 8 } },
        { "Python", new List<int> { 7, 7, 7 } }
    }}
};

void AnalisaMediaNota() {

    foreach (var alunos in notasAlunos.Keys) {
        Console.WriteLine($"Aluno(a): {alunos} ");

        Dictionary<string, List<int>> notas = notasAlunos[alunos];
        foreach (var materia in notas) {
            string nomeMateria = materia.Key;
            List<int> notasDaMateria = materia.Value;
            double media = notasDaMateria.Average();

            Console.WriteLine($"Materia: {nomeMateria}, Notas: {string.Join(", ", notasDaMateria)}, Media: {media:F2}\n");
        }
    }
}

AnalisaMediaNota();

/* Outra maneira de acessar itens em dicionario

List<int> notasPythonMaria = notasAlunos["Maria"]["Python"];
double mediaMariaEmPython = notasPythonMaria.Average();
Console.WriteLine(mediaMariaEmPython);

*/