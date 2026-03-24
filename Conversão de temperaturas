// Variáveis
double opcaoUsuario, opcaoTemperatura, valorSerConvertido, valorPosConversao;
bool Fahrenheit = false, Celsius = false, Kelvin = false;
string resultado = "";

// Parte do usuário
Console.WriteLine("Seja bem-vindo ao programa de calculo de temperaturas. Antes de iniciar o programa, escolha uma das opções abaixo:\n");
Console.WriteLine("1- Celsius\n2 - Fahrenheit\n3 - Kelvin\n");
opcaoUsuario = double.Parse(Console.ReadLine()!);
// Parte do programa
switch (opcaoUsuario) {
        case 1:
        Celsius = true;
    break;
        case 2:
        Fahrenheit = true;
    break;
        case 3:
        Kelvin = true;
    break;
    default: Console.WriteLine("Nenhuma das opções disponíveis...");
        Console.WriteLine("Clique em qualquer tecla para sair");
        Console.ReadKey();
    break;
}
Console.WriteLine("Digite qual a temperatura que será convertida\n");
valorSerConvertido = double.Parse(Console.ReadLine()!);
Console.WriteLine("Escolha abaixo qual das duas temperaturas você quer converter?\n");
if (Celsius) {
    Console.WriteLine("1 - Celsius para Fahrenheit\n2 - Celsius para Kelvin.");
    opcaoTemperatura = double.Parse(Console.ReadLine()!);
    valorPosConversao = (opcaoTemperatura == 1) ? (valorSerConvertido*1.8) + 32 : valorSerConvertido + 273.15;
    resultado = (opcaoTemperatura == 1) ? $"{valorPosConversao}°F" : $"{valorPosConversao}°K";
} else if (Fahrenheit) {
    Console.WriteLine("1 - Fahrenheit para Celsius\n2 - Fahrenheit para Kelvin");
    opcaoTemperatura = double.Parse(Console.ReadLine()!);
    Console.WriteLine(valorSerConvertido);
    valorPosConversao = (opcaoTemperatura == 1) ? (valorSerConvertido - 32) / 1.8 : (5.0/9.0 * (valorSerConvertido - 32)) + 273.15;
    Console.WriteLine(5/9 * (valorSerConvertido - 32));
    Console.WriteLine(valorPosConversao);
    resultado = (opcaoTemperatura == 1) ? $"{valorPosConversao}°C" : $"{valorPosConversao}°K";
} else if (Kelvin) {
    Console.WriteLine("1 - Kelvin para Celsius\n2 - Kelvin para Fahrenheit");
    opcaoTemperatura = double.Parse(Console.ReadLine()!);
    valorPosConversao = (opcaoTemperatura == 1) ? valorSerConvertido - 273.15 : ((valorSerConvertido - 273.15) * 1.8) + 32;
    resultado = (opcaoTemperatura == 1) ? $"{valorPosConversao}°C" : $"{valorPosConversao}°F";
} else {
    Console.WriteLine("Error: Nenhuma das opções foram selecionadas.\nClique em qualquer programa para continuar.");
    Console.ReadKey();
}

Console.WriteLine($"O resultado da conversão que o usuário escolheu é de {resultado}.\nClique em qualquer tecla para sair...");
Console.ReadKey();
