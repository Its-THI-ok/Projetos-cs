// Variáveis
double valorEscolhido, qtdVezes;
//Parte do Usuário
Console.WriteLine("Seja bem-vindo a calculadora de tabuada! Você poderá definir quantas vezes haverá a tábuada e o valor que será multiplicada\nPara começar clique qualquer tecla.\n");
Console.ReadKey();
Console.WriteLine("Digite o valor que será multiplicado pela quantidade de vezes:");
valorEscolhido = double.Parse(Console.ReadLine()!);
Console.WriteLine("Quantas vezes o número será multiplicado?");
qtdVezes = double.Parse(Console.ReadLine()!);
// Debaixo dos panos
Console.WriteLine($"A tabuada de {valorEscolhido} é:");
for (double i = 0; i <= qtdVezes; i++) {
    Console.WriteLine($"{i}x{qtdVezes} = {valorEscolhido*i}");
}
Console.WriteLine("Para sair, clique qualquer tecla");
Console.ReadKey();
