## Calculadora de Idade

Este é um programa simples em C# que calcula a idade de uma pessoa daqui a 10 anos. Ele solicita ao usuário que insira sua idade atual, adiciona 10 a ela e exibe a idade futura.

### Detalhes do código

**Resolução:**

- Para realizar este programa, vamos seguir os seguintes passos:

    - Declaração de uma variável do tipo `int` para armazenar a idade.
    - Utilização do comando `Console.WriteLine();` para exibir uma mensagem ao usuário.
    - Utilização do comando `Console.ReadLine();` para obter a entrada do usuário.
    - Uso do método `int.Parse` para converter a entrada do usuário em um valor inteiro.
    - Adição de 10 à idade digitada pelo usuário.
    - Utilização de interpolação de string para exibir a idade futura.

### Instruções de uso:

1. Ao iniciar o programa, ele solicitará que você insira sua idade atual.
2. Insira sua idade e pressione Enter.
3. O programa calculará e exibirá sua idade daqui a 10 anos.

### Explicando sobre a linha de código
`
idade = int.Parse(Console.ReadLine());
`
- Solicita ao usuário que insira sua idade como uma string, converte essa string em um valor inteiro e armazena o valor convertido na variável idade.

### Explicando sobre a linha de código

`idade += 10;`

- O operador `+=` é um exemplo de um operador de atribuição composta em C#. Ele é usado para adicionar o valor à direita do operador ao valor já presente na variável à esquerda e atribuir o resultado de volta à variável.

 - Ao utilizar `+=` junto à variável idade, que já está preenchida com o valor informado pelo usuário, o operador adiciona 10 à idade atual armazenada na variável, resultando na idade daqui a 10 anos.

 - Em resumo, o operador `+=` é uma ferramenta útil para incrementar o valor de uma variável de forma concisa e eficiente em C#. Ele é comumente usado para atualizar contadores, acumuladores e variáveis em loops e outras estruturas de controle de fluxo.