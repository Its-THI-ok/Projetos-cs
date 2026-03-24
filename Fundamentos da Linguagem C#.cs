// Variáveis!
Random random = new Random();
int qtdPessoas, numeroSorteado;
string resultado = "";

// Parte do usuário
Console.WriteLine($"Quantas pessoas serão sorteadas?");
qtdPessoas = int.Parse(Console.ReadLine()!);
Console.WriteLine($"""
------------------------------------------------------------
Serão sorteados {qtdPessoas} pessoas, o ganhador terá
seu número marcado em verde e o resultado exibido no final!
------------------------------------------------------------
Clique para continuar!
""");
Console.ReadKey();
Console.Clear();
// Parte do Programa
numeroSorteado = random.Next(1, qtdPessoas);
for (int i = 1; i <= qtdPessoas; i++) {
    if (i == numeroSorteado) {
        resultado = String.Concat(resultado, $"\nNúmero sorteado: {i}: GANHOU!");
    } else {
    resultado = String.Concat(resultado, $"\nNúmero sorteado: {i}: Não ganhou.");
    }
}

// Resultado depois das operações do Programa.
Console.WriteLine(resultado);
Console.Write($"O número da sorte foi: ");
Console.BackgroundColor = ConsoleColor.Green;
Console.Write($"  {numeroSorteado}  ");
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("\nDeseja progredir?");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Clique em qualquer tecla para encerrar o programa!");
Console.ReadKey();
Console.Clear();
