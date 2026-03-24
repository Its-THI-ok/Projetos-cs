// Bhaskara
/* Informações importantes antes do programa:
Unicode de Delta = \u0394 ou em String Literal Bruta (Δ);
Unicode de Raiz Quadrada = \u221a ou em String Literal Bruta (√);
*/

// Variáveis
double valorA = 0, valorB = 0, valorC = 0, delta, x1, x2, raizResult;

//Introdução do sistema
Console.WriteLine("--- Calculadora de Bhaskara Passo a Passo ---");
// Parte do Usuário
Console.Write("Informe o valor de A: ");
valorA = double.Parse(Console.ReadLine()!);
Console.Write("Informe o valor de B: ");
valorB = double.Parse(Console.ReadLine()!);
Console.Write("Informe o valor de C: ");
valorC = double.Parse(Console.ReadLine()!);
// Parte pricipal do Programa
Console.WriteLine("\n--- Iniciando os Cálculos ---");
Console.WriteLine("Passo 1: Calcular o Delta (\u0394)\nFórmula: \u0394 = b² - 4ac");
// Parte do cálculo de delta
delta = Math.Pow(valorB, 2) - 4*valorA*valorC;
// Imprimindo o resultado do delta e a conta
Console.WriteLine($"""
Δ = ({valorB})² - 4 * ({valorA}) * ({valorC})
Δ = {Math.Pow(valorB, 2)} - ({4*valorA*valorC})
Δ = {delta}
""");
// Verificando se o Delta deu positivo ou não

if (delta >= 0) {
    // Cálculo das respostas inseridas
    raizResult = Math.Round(Math.Sqrt(delta), 2);
    x1 = Math.Round((valorB*-1 + raizResult)/(valorA*2), 2);
    x2 = Math.Round((valorB*-1 - raizResult)/(valorA*2), 2);
    // Mostrando o cálculo ao usuário
    Console.WriteLine($"""
    Passo 2: Calcular as raízes usando a fórmula de Bhaskara
    Fórmula: x = (-b ± √Δ) / 2a
    x = (-({valorB}) ± √{delta}) / (2 * {valorA})
    x = ({valorB*-1} ± {raizResult}) / {valorA*2}

    Cálculo de x1:
    x1 = ({valorB*-1} + {raizResult}) / {valorA*2}
    x1 = {Math.Round(valorB*-1 + raizResult, 2)} / {valorA*2}
    Resultado de x1 = {x1}

    Cálculo de x2:
    x2 = ({valorB*-1} - {raizResult}) / {valorA*2}
    x2 = {Math.Round(valorB*-1 - raizResult, 2)} / {valorA*2}
    Resultado de x1 = {x2}

    ---------------------------------------
    Pressione qualquer tecla para sair...
    """);
    Console.ReadKey();
    
} else {
    Console.WriteLine($"O \u0394 deu o valor de {delta}, sendo negativo, não podemos continuar a operação.\nClique em qualquer tecla para continuar...");
    Console.ReadKey();
    return;
}
