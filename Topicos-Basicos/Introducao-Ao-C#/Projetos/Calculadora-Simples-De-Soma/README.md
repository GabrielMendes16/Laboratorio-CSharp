
## Calculadora Simples de Soma
Um programa simples que solicita ao usuário inserir dois números e exibe a soma deles.

## Objetivo
Demonstrar como obter dados do usuário e realizar uma operação matemática simples.

## Resolução
Para realizarmos este programa, iremos precisar:

- Criar duas variáveis do tipo decimal
- Utilizar os comandos Console.WriteLine(); e Console.ReadLine();
- Utilizar a conversão para decimal dos valores fornecidos pelo usuário
- Realizar a operação de soma entre os dois números fornecidos

## Demonstração | Declaração de Variáveis

```cscharp
decimal numero1;
decimal numero2;

```

## Demonstração | Solicitação dos Números ao Usuário

```cscharp
Console.WriteLine("Que tal realizarmos uma soma?");
Console.WriteLine("Informe o Primeiro Número:");
numero1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Informe o Segundo Número:");
numero2 = Convert.ToDecimal(Console.ReadLine());

```
## Demonstração | Cálculo da Soma

```csCharp
decimal resultado = numero1 + numero2;

```
## Demonstração | Exibição do Resultado
```cscharp
Console.WriteLine($"Resultado da soma entre {numero1} + {numero2} é = {resultado}");

```
## Curiosidade | Como garantir que a entrada do usuário seja realmente um número?
### Para isso teriamos que Utilizar
- Um Bloco de Tratamento: Para orientar o usuário a fornecer o tipo de dado solicitado corretamente.
- Um Estrutura De Repetição: Para que o programa não encerre caso o usuário forneça um dado que não seja o esperado.

### Exemplo de como ficaria o código do programa
```cscharp
 Console.WriteLine("Que tal realizarmos uma soma?");
        
        decimal numero1 = 0;
        decimal numero2 = 0;
        
        bool entradaValida = false;

        while (!entradaValida)
        {
            Console.WriteLine("Informe o Primeiro Número:");

            try
            {
                numero1 = Convert.ToDecimal(Console.ReadLine());
                entradaValida = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Por favor, insira um número válido para o primeiro número.");
            }
        }

        entradaValida = false;

        while (!entradaValida)
        {
            Console.WriteLine("Informe o Segundo Número:");

            try
            {
                numero2 = Convert.ToDecimal(Console.ReadLine());
                entradaValida = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Por favor, insira um número válido para o segundo número.");
            }
        }

        decimal resultado = numero1 + numero2;

        Console.WriteLine($"Resultado da soma entre {numero1} + {numero2} é = {resultado}");
    

```
## Conclusão
Em resumo, o programa demonstra como obter dados do usuário no console, converter esses dados para o tipo apropriado e realizar uma operação matemática simples. Utilizando os comandos básicos de entrada e saída do console em C#, como Console.WriteLine() e Console.ReadLine(), podemos criar uma calculadora simples que interage com o usuário de forma amigável.