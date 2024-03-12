double temperatura = 0;
Console.WriteLine("Informe a temperatura em graus Celsius:");
if (double.TryParse(Console.ReadLine(), out temperatura))
{
    double resultado = (temperatura * 1.8) + 32;
    Console.WriteLine($"A temperatura em Fahrenheit é: {resultado:F1}");
}
else
{
    Console.WriteLine("Por favor, insira um valor numérico válido.");
}
