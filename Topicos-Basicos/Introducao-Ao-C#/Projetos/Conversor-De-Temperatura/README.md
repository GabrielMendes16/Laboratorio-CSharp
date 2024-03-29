## Conversor de Temperatura Celsius para Fahrenheit

Este é um programa simples em C# que converte temperaturas de graus Celsius para Fahrenheit. Ele solicita ao usuário que insira a temperatura em graus Celsius e, em seguida, calcula e exibe o equivalente em graus Fahrenheit.

### Detalhes do código

**Resolução:**

- Para realizar este programa, vamos seguir os seguintes passos:

- Declaração de duas variáveis do tipo double para armazenar a temperatura em Celsius e Fahrenheit.
- Utilização do comando Console.WriteLine(); para exibir mensagens ao usuário.
- Utilização do comando Console.ReadLine(); para obter a entrada do usuário.
- Uso do modificador out para capturar o resultado da conversão de string para double.
- Utilização da convenção double.TryParse para converter a entrada do usuário em um valor double de forma segura.

### Instruções de uso:

1. Ao iniciar o programa, ele solicitará que você insira a temperatura em graus Celsius.
2. Insira um valor numérico representando a temperatura em graus Celsius e pressione Enter.
3. O programa calculará e exibirá a temperatura equivalente em graus Fahrenheit.


### Curiosidade: Explorando o double.TryParse e o uso de out

- O método **double.TryParse** é uma maneira segura de converter uma string em um valor do tipo double.

### Funcionamento Do Método double.TryParse: 
- Tenta converter a string fornecida em um valor double e retorna um valor booleano indicando se a conversão foi bem-sucedida ou não.

### Por que isso é bom?

- É útil para evitar exceções de formato inadequado de string ou de estouro durante a conversão.
- Se a conversão for bem-sucedida, o valor convertido é armazenado em uma variável fornecida como parâmetro de saída (out).

### Sobre O Modificador out:

Modificador este que indica que um parâmetro de um método é passado por referência. Ou seja o valor da variável passada como argumento para o parâmetro **out** pode ser modificado dentro do método e as alterações são refletidas fora dele.


### Explicando sobre a linha de código
```cscharp
double.TryParse(Console.ReadLine(), out temperatura)
```
### Funcionamento:

Solicita ao usuário que insira uma string representando um número, tenta converter essa string em um valor double e armazena o valor convertido na variável temperatura, se a conversão for bem-sucedida. 

### Por que não usar double.Parse?

A abordagem da **double.TryParse** é mais segura e robusta, pois evita exeções não tratadas em casos de entrada inválida.