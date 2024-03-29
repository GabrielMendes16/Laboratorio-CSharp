# Saudação Personalizada

Um programa simples que solicita ao usuário inserir seu nome e exibe uma mensagem de saudação personalizada.

### Assunto
Demonstra a obtenção de um dado do usuário e sua utilização para criar uma saída personalizada.

### Resolução 
Para realizamos este programa iremos precisar:
- Criar uma variavel do tipo **String**
- Utilizar o comando **Console.Writeline();**
- Utilizar o comando **Console.ReadLine();**
- Utilizar a **interpolação de string**




### Demonstração | Declaração de Variável
```csharp
string nome;
```

### Demonstração | Utilizando o Comando Console.WriteLine(""); Para Criar Uma Mensagem Inicial
```cscharp
Console.WriteLine("Olá, Informe seu nome:");
```

### Demonstração | Associando a Variável Declarada ao Comando Console.ReadLine();
```cscharp
nome = Console.ReadLine();
```

### Demonstração | Utilizando a interpolação de string;
```cscharp
Console.WriteLine($"Olá, {nome} Seja Bem-Vindo ao Programa GreetingPersonalized!");

```

### Curiosidade
Uma curiosidade interessante sobre a obtenção de dados do usuário no console é que, embora o método Console.ReadLine() seja comumente usado para essa finalidade, ele possui algumas limitações. Por exemplo, ele apenas captura uma linha de entrada do usuário, o que significa que se o usuário digitar múltiplas palavras, somente a primeira linha será lida. Além disso, ele retorna uma string, o que pode exigir conversões adicionais se você precisar de outros tipos de dados. No entanto, apesar dessas limitações, o Console.ReadLine() é uma ferramenta poderosa e amplamente utilizada para interação com o usuário em aplicativos de console.

### Então
Em resumo, o programa demonstra de forma simples e direta como obter dados do usuário no console e utilizar esses dados para criar uma saída personalizada. Utilizando os comandos básicos de entrada e saída do console em C#, como Console.WriteLine() e Console.ReadLine(), juntamente com a interpolação de strings, podemos criar uma experiência de usuário mais interativa e personalizada.
