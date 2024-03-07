int somatorio= 5;

int sofia1 = 93;
int sofia2 = 87;
int sofia3 = 98;
int sofia4 = 95;
int sofia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zayra1 = 84;
int zayra2 = 96;
int zayra3 = 73;
int zayra4 = 85;
int zayra5 = 79;

int jean1 = 90;
int jean2 = 92;
int jean3 = 98;
int jean4 = 100;
int jean5 = 97;

int sofiaSoma = sofia1 + sofia2 + sofia3 + sofia4 + sofia5;
int nicolasSoma = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zayraSoma = zayra1 + zayra2 + zayra3 + zayra4 + zayra5;
int jeanSoma = jean1 + jean2 + jean3 + jean4 + jean5;

decimal sofiaPontuacao = (decimal) sofiaSoma / somatorio;
decimal nicolasPontuacao = (decimal) nicolasSoma / somatorio;
decimal zayraPontuacao = (decimal) zayraSoma / somatorio;
decimal jeanPotuacao = (decimal) jeanSoma / somatorio;

Console.WriteLine("Estudantes\t\tGrade\n");
Console.WriteLine("Sofia:\t\t" + sofiaPontuacao + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasPontuacao + "\tB");
Console.WriteLine("Zayra:\t\t" + zayraPontuacao + "\tB");
Console.WriteLine("Jean:\t\t" + jeanPotuacao + "\tA");