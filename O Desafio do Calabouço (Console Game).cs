// Variáveis
Random random = new Random();
int vidaHeroi = 100, vidaMonstro = 100, valorAtualHeroi = 0, valorAtualMonstro = 0, critico = 0, cura = 0, defesaMonstro = 0;
int opcaoHeroi, opcaoMonstro, punicao = 0;

// Parte do usuário
Console.WriteLine($"""
 -----------------------------------------------------------------------
| Seja bem vindo ao jogo de Combate, você, herói enfrentará um monstro! |
| A sua vida começará com 100 pontos.                                   |
| O monstro também.                                                     |
|                                                                       |
| [REGRAS]:                                                             |
| Vence quem derrotar o outro primeiro antes de 10 rodadas.             |
| Se ambos não derrotarem um ao outro até a rodada 10, será considerado |
| EMPATE.                                                               |
| Clique em qualquer tecla para jogar!                                  |
 -----------------------------------------------------------------------
""");
Console.ReadLine();
Console.Clear();
// História
Console.Write("Enquanto você estava andando pela floresta, apareceu um monstro.\nE ele veio ao seu encontro!");
Console.ReadKey();
Console.Clear();

// Parte do programa
for (int i = 1; i <= 10; i++) {
    // Sempre redefinindo os valores:
    valorAtualHeroi = 0;
    valorAtualMonstro = 0;

    // Validador de condição do jogo:
    if (i >= 10 && vidaHeroi > 0 && vidaMonstro > 0) {
        Console.WriteLine("EMPATE\nClique para finalizar o jogo.");
        Console.ReadKey();
        return;
    } else if (vidaMonstro <= 0) {
        Console.WriteLine("VOCÊ GANHOU!\nClique para finalizar o jogo.");
        Console.ReadKey();
        return;
    } else if (vidaHeroi <= 0) {
        Console.WriteLine("VOCÊ PERDEU!\nClique para finalizar o jogo.");
        Console.ReadKey();
        return;
    } else {
    // Sempre limpa a tela para mostrar a interface:
    Console.Clear();
    Console.WriteLine(valorAtualMonstro);
    // Mostre ao jogador o gráfico do jogo:
    Console.WriteLine($"""
 --------------------------------------EM GAME-----------------------------------------
| Rodada {i} de 10 restantes.                                                          |
 ------------------------------------------------------------------------------------- |
|[============{vidaHeroi}===============] VS [============{vidaMonstro}===============]|
|                                                                                      |
|Opcões:                                                                               |
| Opcão 1: Ataque normal                                                               |
| Opção 2: Defender/Curar                                                              |
| Opção 3: Ataque Especial                                                             |
 --------------------------------------------------------------------------------------
""");

    Console.WriteLine("Qual opção você escolhe?");
    opcaoHeroi = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Clique em qualquer tecla para continuar o jogo!");
    Console.ReadKey();
    Console.Clear();
    // Heroi
    switch (opcaoHeroi) {
        case 1:
            // Ataque normal dá dano de 10-15
            valorAtualHeroi = random.Next(10, 16);
            Console.WriteLine($"O dano foi de {valorAtualHeroi} pontos");
            Console.ReadKey();
            Console.Clear();
        break;
        case 2:
            if (vidaHeroi >= 100) {
                punicao = random.Next(10, 21);
                Console.WriteLine($"Você não pode se curar! Por excesso de vida, você perderá {punicao} de vida.");
                vidaHeroi -= punicao;
            } else {
                cura= random.Next(5, 13);
                Console.WriteLine($"Você se curou em {cura}");
                vidaHeroi += cura;
            }
        break;
        case 3:
            critico = random.Next(0, 11);
            Console.WriteLine($"{critico}");
            if (critico >= 7) {
                // Ataque normal dá dano de 10-15
                valorAtualHeroi = random.Next(10, 16) + 20;
                Console.WriteLine($"Você deu dano crítico, irá dar um dano de {valorAtualHeroi}, mas você irá perder 5 pelo cansaço.");
                vidaHeroi -= 5;
            } else {
                Console.WriteLine("Você lançou o ataque crítico, mas errou. Devido a isso, irá perder 5 pelo cansaço.");
                vidaHeroi -= 5;
            }
            critico = 0;
        break;
        default:
            Console.WriteLine("Você errou o ataque\nPerdeu 5 de vida, devido ao cansaço.");
            vidaHeroi -= 5;
        break;
    }
    Console.WriteLine("É a vez do monstro!");
    Console.ReadKey();
    Console.Clear();

    // Monstro
    opcaoMonstro = random.Next(1, 5);

    switch (opcaoMonstro) {
        case 1:
            valorAtualMonstro = random.Next(5, 21);
            Console.WriteLine($"O ataque do monstro tirou {valorAtualMonstro} de sua vida.");
        break;
        case 2:
            defesaMonstro = random.Next(1, 15);
            if (valorAtualHeroi - defesaMonstro >= 0) {
            Console.WriteLine($"O monstro se defendeu, seu ataque sofreu ineficiência de {defesaMonstro} pontos.");
            valorAtualHeroi -= defesaMonstro;
            } else {
                valorAtualHeroi = 0;
            }
        break;
        case 3:
        critico = random.Next(0, 11);
            if (critico >= 7) {
                valorAtualMonstro = random.Next(1, 15) + 20;
            Console.WriteLine($"O monstro te deu um ataque crítico, você perdeu {valorAtualMonstro}.");
            } else {
                Console.WriteLine("O monstro errou o ataque crítico.");
            }
        break;
        default:
            Console.WriteLine("O monstro não fez nada.");
        break;
    }
    Console.WriteLine("Clique para continuar!");
    Console.ReadKey();
    

    // Inserindo os eventos:
    vidaHeroi -= valorAtualMonstro;
    vidaMonstro -= valorAtualHeroi;
    }
}
