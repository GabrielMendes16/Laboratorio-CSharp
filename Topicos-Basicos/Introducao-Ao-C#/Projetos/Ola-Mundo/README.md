# Olá, Mundo! 
Este é um projeto de exemplo destinado a mostrar como usar a função Console.WriteLine() na linguagem C#. Aqui, você aprenderá como criar um simples programa de console que exibe a mensagem "Olá, Mundo!"

## Demonstração

```csharp
dotnet new console -n ola-mundo
```
Este comando criará um novo projeto de console com o nome **"ola-mundo"**.


## Após Criação do Projeto

Procure pelo arquivo chamado Program.cs, pois é nele que você irá escrever seu primeiro código, após localizar escreve o seguinte comando: **Console.WriteLine("");**

## Demonstração

```csharp
Console.WriteLine("");
```
### Explicando O Comando
O comando Console.WriteLine("") é uma instrução em C# que escreve uma linha de texto na saída padrão do console. Você pode substituir o texto dentro das aspas pelo conteúdo que deseja imprimir. Por exemplo: **Console.WriteLine("Olá, mundo!");**

## Demonstração

```csharp
Console.WriteLine("Olá Mundo");
```
A utilização deste comando irá imprimirá "Olá, mundo!" na tela do console.

## Curiosidade

O comando **Console.WriteLine**, é uma classe e um método da linguagem C#.

**Console** é uma classe que fornece funcionalidades para entrada e saída de dados no console. Ele contém métodos para exibir informações no console, ler entrada do usuário e muito mais.

**WriteLine** é um método da classe Console que escreve uma linha de texto no console. Ele aceita uma string como argumento e exibe essa string no console, seguida por uma quebra de linha.

## Então

Quando você escreve **Console.WriteLine("Olá Mundo");**, você está chamando o método **WriteLine** da **classe Console** e passando a string "Olá Mundo" como argumento, que será exibida no console seguida por uma quebra de linha.