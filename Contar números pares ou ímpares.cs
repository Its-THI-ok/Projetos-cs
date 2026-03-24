// Variáveis
double numero1, numero2, resultado = 0, opcao, limit;
//Parte do usuário
Console.WriteLine("Informe dois números para calcular a quantidade de pares e impares que ele possuí.\nPrimeiro número:");
numero1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Informe o segundo número:");
numero2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Você quer o número par ou Ímpar?\n1- Par\n2 - Ímpar");
opcao = double.Parse(Console.ReadLine()!);
//Debaixo do panos
/* EXPLICAÇÔES:
    A variável limit vai definir o limite para um loop, funcionando da seguinte forma:
    A validação (numero1 > numero2) vai determinar qual valor o limit vai receber, se a validação for verdadeira,
    ele recebe o valor numero1, senão o valor numero2.
    No caso do loop, o i fará a mesma coisa, a diferença é que ele pegará o menor valor, ou seja, isso vai permitir fazermos a operação
    sem precisar criar uma cadeia de loop, deixando o código mais limpo.
    E o switch case irá definir a opção do usuário.
*/
limit = (numero1 > numero2) ? numero1:numero2;

switch (opcao) {
    case 1:
        for (double i = (numero1 < numero2) ? numero1:numero2; i <= limit; i++) {
            if (i % 2 == 0) {
                resultado++;
            }
        }
    break;
    case 2:
        for (double i = (numero1 < numero2) ? numero1:numero2; i <= limit; i++) {
            if (i % 2 != 0) {
                resultado++;
            }
        }
    break;
    default: 
        Console.WriteLine("nenhuma das opções foram selecionadas.");
    break;
}
// Tratamento de erro.
if (opcao < 0 || opcao > 3) {
    Console.WriteLine("ERROR NULL:\nVocê não selecionou nenhum dos tipos.\nClique em qualquer tecla para sair...");
    Console.ReadLine();
    return;
    }
Console.WriteLine((opcao == 1) ? $"\nHá {resultado} Pares":$"\nHá {resultado} Ímpares.");
Console.ReadKey();
