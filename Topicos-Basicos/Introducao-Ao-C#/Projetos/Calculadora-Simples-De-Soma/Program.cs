decimal numero1 = 0;
decimal numero2 = 0;
Console.WriteLine("Que tal realizarmos uma soma?");
Console.WriteLine("Informe O Primeiro Número:");
numero1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Informe O Segundo Número:");
numero2 = Convert.ToDecimal(Console.ReadLine());
decimal resultado = numero1 + numero2;
Console.WriteLine($"Resultado da soma entre {numero1} + {numero2} é = {resultado}");

int primeiraEntradaDoUsuario = 0;
int segundaEntradaDoUsuario = 0;

Console.WriteLine("Primeira Entrada:");
primeiraEntradaDoUsuario = int.Parse(Console.ReadLine());


Console.WriteLine("Segunda Entrada:");
segundaEntradaDoUsuario = int.Parse(Console.ReadLine());


int somaDasEntradas = primeiraEntradaDoUsuario + segundaEntradaDoUsuario;


Console.WriteLine($"Resultado da soma entre:  {primeiraEntradaDoUsuario} + {segundaEntradaDoUsuario} = {somaDasEntradas}");