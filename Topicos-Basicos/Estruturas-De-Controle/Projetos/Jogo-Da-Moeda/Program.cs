string jogador1 = "";
string jogador2 = "";
string escolhaDoJogador1 = "";
string escolhaDoJogador2 = "";


Console.WriteLine("Bem vindo ao jogo do cara e coroa, Vamos jogar?");
Console.WriteLine("Infome o nome do primeiro jogador");
jogador1 = Console.ReadLine();
Console.WriteLine("Infome o nome do primeiro Segundo Jogador");
jogador2 = Console.ReadLine();

int escolha = 0;
Console.WriteLine("O primeiro jogdor define se deseja cara ou coroa");
Console.WriteLine("Digite 1 para cara ou 2 para coroa");
escolha = int.Parse(Console.ReadLine());


if (escolha == 1)
{
    escolhaDoJogador1 = "Cara";
    escolhaDoJogador2 = "Coroa";
}
else if (escolha == 2)
{
    escolhaDoJogador1 = "Coroa";
    escolhaDoJogador2 = "Cara";
}

Console.WriteLine($"Então ficou assim: {jogador1} ficou com {escolhaDoJogador1} e {jogador2} ficou com {escolhaDoJogador2}");


int pontuacaoDoJogador1 = 0;
int pontuacaoDoJogador2 = 0;

Random dice = new Random();

while (true)
{
    int roll = dice.Next(1, 3);

    if (roll == 1 && escolhaDoJogador1 == "Cara")
    {
        Console.WriteLine($"A moeda rodou e deu Cara, {jogador1} acertou! ");
        pontuacaoDoJogador1++;
    }
    else if (roll == 2 && escolhaDoJogador1 == "Coroa")
    {
        Console.WriteLine($"A moeda girou e deu Coroa, {jogador1} acertou!");
        pontuacaoDoJogador1++;
    }
    else if (roll == 1 && escolhaDoJogador2 == "Cara")
    {
        Console.WriteLine($"A moeda rodou e deu Cara, {jogador2} acertou!");
        pontuacaoDoJogador2++;
    }
    else if (roll == 2 && escolhaDoJogador2 == "Coroa")
    {
        Console.WriteLine($"A moeda girou e deu Coroa, {jogador2} acertou!");
        pontuacaoDoJogador2++;
    }
    else
    {
        Console.WriteLine("Ninguém acertou desta vez!");
    }

    Console.WriteLine("Deseja continuar jogando? (s/n)");
    string resposta = Console.ReadLine();

    if (resposta.ToLower() != "s")
        break;
}
Console.Clear();

Console.WriteLine("Tabela de Pontuações");
Console.WriteLine($"Jogadores\tPontuação");
Console.WriteLine($"{jogador1}\t\t{pontuacaoDoJogador1}");
Console.WriteLine($"{jogador2}\t\t{pontuacaoDoJogador2}");


