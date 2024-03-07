string nomeAluno = "Sophia Johnson";
string nomeCurso1 = "Inglês 101";
string nomeCurso2 = "Álgebra 101";
string nomeCurso3 = "Biologia 101";
string nomeCurso4 = "Ciência da Computação I";
string nomeCurso5 = "Psicologia 101";

int creditosCurso1 = 3;
int creditosCurso2 = 3;
int creditosCurso3 = 4;
int creditosCurso4 = 4;
int creditosCurso5 = 3;

int notaA = 4;
int notaB = 3;

int notaCurso1 = notaA;
int notaCurso2 = notaB;
int notaCurso3 = notaB;
int notaCurso4 = notaB;
int notaCurso5 = notaA;

int totalHorasCredito = 0;
totalHorasCredito += creditosCurso1;
totalHorasCredito += creditosCurso2;
totalHorasCredito += creditosCurso3;
totalHorasCredito += creditosCurso4;
totalHorasCredito += creditosCurso5;

int totalPontosNota = 0;
totalPontosNota += creditosCurso1 * notaCurso1;
totalPontosNota += creditosCurso2 * notaCurso2;
totalPontosNota += creditosCurso3 * notaCurso3;
totalPontosNota += creditosCurso4 * notaCurso4;
totalPontosNota += creditosCurso5 * notaCurso5;

decimal mediaPontosNota = (decimal) totalPontosNota / totalHorasCredito;

int digitoPrincipal = (int) mediaPontosNota;
int primeiroDigito = (int) (mediaPontosNota * 10) % 10;
int segundoDigito = (int) (mediaPontosNota * 100) % 10;

Console.WriteLine($"Aluno: {nomeAluno}\n");
Console.WriteLine("Curso\t\t\t\tNota\tCréditos");

Console.WriteLine($"{nomeCurso1}\t\t\t{notaCurso1}\t\t{creditosCurso1}");
Console.WriteLine($"{nomeCurso2}\t\t\t{notaCurso2}\t\t{creditosCurso2}");
Console.WriteLine($"{nomeCurso3}\t\t\t{notaCurso3}\t\t{creditosCurso3}");
Console.WriteLine($"{nomeCurso4}\t\t{notaCurso4}\t\t{creditosCurso4}");
Console.WriteLine($"{nomeCurso5}\t\t\t{notaCurso5}\t\t{creditosCurso5}");

Console.WriteLine($"\nMédia Final:\t\t\t {digitoPrincipal}.{primeiroDigito}{segundoDigito}");
