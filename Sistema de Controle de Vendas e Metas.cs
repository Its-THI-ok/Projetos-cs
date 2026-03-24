// Variáveis
int smartPhoneVendido = 0, laptopVendido = 0, acessorioVendido = 0, qtdVendas, opcao;
double valorProdutoAtual, valorTotalVendas = 0, valorTotalComissoes = 0;
string meta, nomeVendedor;

// Parte do Usuário
Console.WriteLine("""
---------------- Program as started --------------------
Seja bem vindo ao programa de controle de vendas e metas.
Será mostrado um relatório da seguinte forma:
Nome do vendedor

[INFO:] Qualquer outro número que não esteja nos respectivos
códigos será considerados como sem comissão.

Quantia exata de produtos vendidos na seguinte sequência
e com seus respectivos códigos:
1 - SmartPhone
2 - Laptop
3 - Acessório

O Valor total das comissões
E se atingiu a meta de R$ 20.000,00.
---------------------------------------------------------
Clique para continuar...
""");
Console.ReadKey();
Console.Clear();

Console.WriteLine("Qual o nome do vendedor?");
nomeVendedor = Console.ReadLine()!;
Console.Clear();

Console.WriteLine("Quantas vendas serão registradas?");
qtdVendas = int.Parse(Console.ReadLine()!);
Console.Clear();

for (int i = 0; i < qtdVendas; i++) {
    Console.WriteLine($"""
    -----------------------------------------------------------
    [INFO:] Qualquer outro número que não esteja nos respectivos
    códigos será considerados como sem comissão.

    [INFO:] {i}/{qtdVendas} registrados.

    Qual é o tipo do dispositivo?
    Lembrando de:
    1 - SmartPhone
    2 - Laptop
    3 - Acessorio

    """);
    opcao = int.Parse(Console.ReadLine()!);
    Console.Clear();

    Console.Write("Qual é o valor do produto: R$");
    valorProdutoAtual = double.Parse(Console.ReadLine()!);
    valorTotalVendas += valorProdutoAtual;

    switch (opcao) {
        case 1:
        Console.WriteLine("O Valor da comissão de SmartPhone é de 5% sobre o valor da venda");
        if (valorTotalVendas >= 5000) {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("[AVISO]: Venda de Alto Valor!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
            valorTotalComissoes += valorProdutoAtual * (5.0/100.0);
            smartPhoneVendido++;
        break;
        case 2:
            Console.WriteLine("O Valor da comissão de Laptop é de 10% sobre o valor da venda");
        if (valorProdutoAtual >= 5000) {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("[AVISO]: Venda de Alto Valor!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
            valorTotalComissoes += valorProdutoAtual * (10.0/100.0);
            laptopVendido++;
        break;
        case 3:
            Console.WriteLine("O Valor da comissão de Acessório é de 12% sobre o valor da venda");
        if (valorProdutoAtual >= 5000) {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("[AVISO]: Venda de Alto Valor!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
            valorTotalComissoes += valorProdutoAtual * (12.0/100.0);
            acessorioVendido++;
        break;
        default:
            Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("A opção escolhida está selecionada como item sem comissão.");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        if (valorProdutoAtual >= 5000) {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("[AVISO]: Venda de Alto Valor!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        break;
    }
    Console.WriteLine("Clique em qualquer tecla para ir ao próximo passo.");
    Console.ReadKey();
    Console.Clear();
}
// Definindo o operador tenário da variável meta
meta = (valorTotalVendas >= 20000) ? "SIM" : "NÃO";
// Menu demonstrando Resultados
Console.WriteLine($"""
Nome do Vendedor:
{nomeVendedor}

Valor total das vendas:
R$ {valorTotalVendas}

Quantidade de itens vendidos:
{smartPhoneVendido} SmartPhones
{laptopVendido} Laptops
{acessorioVendido} Acessorios

Valor Total da comissão:
R$ {valorTotalComissoes}

Você atingiu a meta?
Resposta: {meta}

Clique em qualquer tecla para sair
""");
Console.ReadKey();
