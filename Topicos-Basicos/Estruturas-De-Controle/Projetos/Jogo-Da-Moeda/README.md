## Jogo da Moeda
Programa  simula um jogo simples de cara ou coroa entre dois jogadores, onde cada jogador faz uma escolha (cara ou coroa) e uma moeda é lançada para determinar o vencedor.

### Resolução
O programa criar uma simulação do jogo. Ele solicita os nomes dos jogadores, permite que o primeiro jogador escolha entre cara e coroa, simula o lançamento da moeda e determina o vencedor com base nas escolhas dos jogadores.

### Demonstração De Possível Sáida 
```cscharp
Bem vindo ao jogo do cara e coroa, Vamos jogar?
Informe o nome do primeiro jogador: Alice
Informe o nome do segundo jogador: Bob
O primeiro jogador define se deseja cara ou coroa.
Digite 1 para cara ou 2 para coroa: 1
Então ficou assim: Alice ficou com Cara e Bob ficou com Coroa.

A moeda rodou e deu Cara, Alice acertou!
Deseja continuar jogando? (s/n): s
...
Tabela de Pontuações
Jogadores   Pontuação
Alice       5
Bob         3

- A tabela De Pontuações só será exibida caso o usuário não deseje mais continuar jogando.
```

## Curiosidade | Uso da classe Randon
Usamos a classe Random para simular o lançamento da moeda. A classe Random é uma ferramenta poderosa em programação para gerar números aleatórios, e neste programa ela é utilizada para determinar o resultado do lançamento da moeda.

## Conclusão
O "Jogo da Moeda" é um programa simples, mas ilustra conceitos importantes de lógica de programação, como entrada de dados, estruturas condicionais e uso de números aleatórios. Além disso, é uma maneira divertida de explorar o funcionamento básico de um jogo em um ambiente de console.