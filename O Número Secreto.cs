// Construtores
Random random = new Random();

// Variáveis
int numeroSorteado, opcaoUsuario = 0;

// Inserindo eventos iniciais
// 1 é o início e 100 é o final, coloquei o 101 porque ele remove um do final.
numeroSorteado = random.Next(1, 101);

// Parte do usuário
Console.WriteLine("""
Seja bem-vindo ao programa do número da sorte!
Você deve escolher um número de 1 a 100, vale
lembrar que você só tem 7 tentativa para acertar!
BOA SORTE!

Clique em qualquer tecla para continuar.
""");
// Programa
for (int i = 0; i <= 8; i++) {
    // Limpadores
    Console.ReadKey();
    Console.Clear();
    // Info:
    if (i <= 7) {
        Console.WriteLine($"Quantidade de tentativas restantes: {7 - i}");
        Console.WriteLine("Qual número você acha que é?");
            opcaoUsuario = int.Parse(Console.ReadLine()!);
    } else {
        Console.WriteLine("Ops! O limite estourou!\nClique em qualquer tecla para finalizar o programa.");
        Console.ReadKey();
        Console.Clear();
        return;
    }
    // Checador de contagem.
    if (numeroSorteado == opcaoUsuario) {
        Console.WriteLine("Você acertou! Parabéns");
        return;
    } else {
        // Opções caso a informação não seja validada. Primeira instância.
        if (opcaoUsuario > numeroSorteado) {
            Console.WriteLine("Muito Alto! Tente novamente com um número menor!");
        } else {
            Console.WriteLine("Muito Baixo! Tente novamente com um número maior!");
        }
    }
}
