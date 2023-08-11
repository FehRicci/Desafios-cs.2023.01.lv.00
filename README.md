# Desafios-cs.2023.01.lv.00
**Exercícios passados na mentoria cs.2023.01.lv.00.**

Index

[1. Calculadora](#Calculadora)
2. Soma e Média
3. Jogar dados
4. Datas
5. Conversão de Moedas
6. Jogo da Forca
7. Tabuada
8. Faça um programa para calcular o estoque médio de uma peça
9. .
10. Faça um programa para pagamento de comissão de vendedores de peças
11. Caixa Eletronico
12. Controle de Estoque. Faça uma aplicação que atenda os seguintes requisitos



## 1. Calculadora 
Objetivo: usando uma aplicação do tipo console do dotnet, criar uma calculadora simples que terá as operações de soma, subtração, multiplicação e divisão. Faça o controle de versionamento da sua aplicação com git e suba a mesma para o github.

Novos conceitos ou funcionalidades desse exercício
Nossa primeira aplicação é bem simples e, se você já tem conhecimentos em lógica de programação, algoritmos e alguma linguagem de programação não terá problemas para desenvolver a aplicação. Faremos uso de operadores condicionais, estrutura condicional 'switch', criação e chamada de métodos simples.

Requisitos para desenvolver a aplicação
Ao entrar na calculadora o usuário deverá ter um menu com as opções 1, 2, 3, 4 e 0. Sendo elas:

1 - Somar

2 - Subtrair

3 - Multiplicar

4 - Dividir

0 - Sair

Todas as operações devem solicitar que o usuário entre com dois valores e então estes valores devem ser utilizados para realizar a operação escolhida. Exemplo de fluxo da operação de Soma:

Aplicação solicita o primeiro valor;
Usuário digita valor e pressiona enter;
Aplicação solicita o segundo valor;
Usuário digita valor e pressiona enter;
Aplicação escreve em tela o resultado da soma;
Usuário pressiona Enter;
Aplicação retorna para o menu;
Para a operação de divisão, validar se o divisor é 0. Se verdadeiro deve ser exibida a mensagem "Não é possível dividir por zero."

Opcional

Fazer o controle de versionamento da sua aplicação usando git;
Subir a aplicação para um repositório do github.
Desafios
Crie uma nova opção na calculadora (opção número 5 do menu) que retorne o resto da divisão.
Crie uma nova opção na calculadora (opção número 6 do menu) que retorne o resultado da potenciação de uma determinada base pelo seu expoente. Exemplo 2³ = 8.

##  2. Soma e Média
Objetivo: usando uma aplicação do tipo console do dotnet, criar uma aplicação que lê 3 à 10 números e realiza a soma e a média deles. Faça o controle de versionamento da sua aplicação com git e suba a mesma para o github.

Novos conceitos ou funcionalidades desse exercício
Faremos uso de loops e arrays no exercício, tente fazer o mesmo usando ´for´ e o ´foreach´. Faça o possível também para criar métodos que recebam parâmetros e retornem valores, dessa forma teremos uma codificação mais limpa e de fácil leitura.

Estudar:

Criação de métodos
Receber parâmetros nos métodos
Retorno de valores nos métodos
Classe ´List´ do Dotnet
Loops ´for´ e ´foreach´
Requisitos para desenvolver a aplicação
Ao abrir a aplicação deverá ser solicitado a quantidade de números que o usuário deseja informar. O número de valores deve ser entre 3 e 10.

A aplicação deve aceitar números decimais, positivos e negativos.

A aplicação deve percorrer a lista de números, calcular a soma e a média dos valores informados e imprimir o resultado para o usuário.

Opcional

Fazer o controle de versionamento da sua aplicação usando git;
Subir a aplicação para um repositório do github.
Desafios
Validar se os números digitados pelo usuário são validos (estude o TryParse para fazer esse desafio).
Faça o uso da biblioteca "System.Linq" do Dotnet para fazer a soma (sum) e a média (average) da lista (array) de valores. 

## 3. Jogar dados
Objetivo: usando uma aplicação do tipo console do dotnet, criar um jogo simplificado onde dois jogadores podem jogar dados e a aplicação informa qual dos jogadores tirou o maior número. Faça o controle de versionamento da sua aplicação com git e suba a mesma para o github.

Novos conceitos ou funcionalidades desse exercício
Usaremos nesse exercício a classe Random do dotnet para simular uma jogada de dados com 6 lados. O random irá possibilitar que tiremos um número aleatório (de 1 a 6 para nosso exemplo). Você pode usar loop para esse exercício, estude sobre loops caso não conheça. Poderá também optar por usar recursão (o exemplo de consulta usa recursão no método "IniciarRodadas"), recomendo estudar sobre recursão também antes de iniciar o exercício.

Requisitos para desenvolver a aplicação
Quando o usuário abrir o jogo deverá ser solicitado o nome do primeiro e do segundo jogador. Não será possível jogar com mais do que dois jogadores.

O jogo deverá solicitar um nome para cada jogador e os nome não podem ser iguais.

O jogo terá 3 rodadas, o jogador que tirar o maior número no dados na maioria das jogadas vence a partida.

Em caso de empate (onde os dois tiram o mesmo número) nenhum jogador pontuará.

A cada rodada a aplicação deve informar quem foi o jogador vencedor. Exemplos de mensagens:

João tirou o número 2 e Maria o número 6. Maria venceu a rodada 1.
João tirou o número 1 e Maria o número 1. Empate.
Um placar sempre deve ser exibido até o final do jogo para que os jogadores acompanhem o resultado. Exemplo: Pontos do jogador Maria: 1 Pontos do jogador João: 0

Ao final da rodada 3 a aplicação deve informar quem foi o vencedor ou se foi um empate.

Opcional

Fazer o controle de versionamento da sua aplicação usando git;
Subir a aplicação para um repositório do github.
Desafios
Se a terceira rodada terminar em empate, faça com que os jogadores continuem jogando dados. O próximo a pontuar ganha o jogo.
Crie uma opção antes de iniciar o jogo que permite que o usuário selecione a quantidade de rodadas. A quantidade deve estar entre 1 e 5.

## 4. Datas
Objetivo: usando uma aplicação do tipo console do dotnet, criar uma aplicação que listará algumas datas importante da área da técnologia, escolhar 5 datas ou utilize os sugeridos nos requisitos.

Novos conceitos ou funcionalidades desse exercício
Usaremos nesse exercício a classe DateTime do dotnet então antes ou durante o exercício estude sua documentação. Tente desenvolver o exercício criando uma classe chamada "DataConfiguracao" (você pode usar outro nome se preferir) a classe deverá conter os métodos responsáveis por configurar o formato escolhido, método para aplicar o formato da data, método para exibir o cabeçalho com a data no formato específicado, etc.

Estude:

Classes, métodos, propriedades e construtores.
Modificadores de acesso: público, privado e protegido.
Retornando valores nos métodos.
Recebendo valores em atributos de métodos.
Requisitos da aplicação
Quando o usuário abrir a aplicação deve ser solicitado qual o formato de data ele deseja visualizar. Deve ser disponibilizada as formatações abaixo:
Utilizar minha configuração de sistema: 08/01/2021 20:48:13 (Este item deve apenas converter a data para string, deixar que o sistema use o formato dele)
Formato simples: 08-01-21
Formato longo sexta-feira, 8 de janeiro de 2021
Formato longo personalizado 08-01-2021 08:48:13
Formato RFC1123 pattern Fri, 08 Jan 2021 20:48:13 GMT
Você deverá mostrar as datas conforme os formatos nos exemplos acima. Siga as dicas abaixo:

Estude como usar o string.Format para personalizar o formato da data.
Estude as conversões para string específicas para DateTime.
Para o item 5, verifique como aplicar o formato RFC1123Pattern para o DateTime.
Na seleção do formato da data, valide a opção e exiba uma mensagem caso não esteja entre 1 e 5 conforme opções do primeiro requisito, e volte para o menu da seleção do formato da data para que o usuário tente novamente.

Após seleção correta de uma opção exiba um segundo menu com as seguintes opções (ou use outras de sua escolha): 1- ENIAC 2- RFC1 3- Alan Turing

Ao escolher uma das opções o sistema deverá exibir para o usuário um cabeçalho com a data do evento e um texto com a descrição do evento. Abaixo você encontra as datas e textos dos eventos sugeridos acima:

(ENIAC) - 15 de agosto de 1946 No dia 15 de agosto de 1946 os norte-americanos John Eckert e John Mauchly apresentaram o ENIAC, o primeiro equipamento eletrônico chamado de computador no mundo.

(RFC1) - 17 de abril de 1969 Em 17 de abril de 1969 foi feita a publicação da RFC1, por esse motivo considera-se esse o dia da internet até hoje.

(Alan Turing) - 23 de junho de 1912 Nascimento de Alan Turing, matemático e criptoanalista britânico que é considerado o "pai da informática" por ter sido essencial na criação de máquinas que, mais tarde, dariam origem aos PCs que utilizamos hoje para trabalhar, estudar e realizar nossas atividades diárias. Sua genialidade e influência fundamental na história da humanidade, entretanto, foram ceifadas pelo preconceito de uma época que, felizmente, já ficou para trás.

Opcional

Fazer o controle de versionamento da sua aplicação usando git;
Subir a aplicação para um repositório do github.
Desafios
Estude novos formatos de datas e aplique mais opções ao menu de escolha de formato de data.
Estude a classe System.Globalization.CultureInfo e aplique novos formatos utilizando ela.

## 5. Conversão de Moedas
Objetivo: usando uma aplicação do tipo console do dotnet, criar uma aplicação que converterá o real ( R$ ) para as moedas dólar ( $ ), euro ( € ), iene ( ¥ ) e libra esterlina ( £ ).

Legenda
Real: moeda brasileira

Dólar: moeda norte americana
Euro: moeda europeia
Iene: moeda japonesa
Libra esterlina: moeda do Reino Unido
Novos conceitos ou funcionalidades desse exercício
Enum (Enumeration types) pode ser utilizado para controlar as moedas, estude como usar enumeradores no C#. Usaremos nesse exercício a classe System.Globalization.CultureInfo. Você pode customizar a exibição do valor da moeda usando as conversões de string sem utilizá-la, mas o ideal é conhecer o CultureInfo, isso facilitará seu trabalho, então estude como formatar as moedas utilizando-a. Estude também sobre os tipos mais indicados para moedas e qual o motivo. Durante o exercício dê preferência para o decimal, pois geralmente ele é o mais indicado na maioria das situações. Lembre-se de utilizar os conceitos já utilizados nos exercícios anteriores.

Estude:

Enumeration types.
Classe System.Globalization.CultureInfo.
Tipos decimal, double, float.
Classe Math.
Conversão de string para moedas.
Conversões implícitas e explicitas.
Documentação XML para C#.
Requisitos da aplicação
Ao abrir a aplicação solicite o valor em real (R$) que o usuário deseja converter.

Após leitura do valor a ser convertido, exibir um menu para selecionar para qual moeda o usuário deseja converter: dólar ($), euro (€), iene (¥) ou libra esterlina (£).

Para realizar a conversão utilize os valore fictícios abaixo:

dólar ( $ ) = R$ 4,50
euro ( € ) = R$ 6,20
iene ( ¥ ) = R$ 0,052
libra ( £ ) = R$ 6,95
Opcional

Fazer o controle de versionamento da sua aplicação usando git;
Subir a aplicação para um repositório do github.
Estude o uso de Dictionary e utilize-o para armazenar o valor de cada moeda que será usado na conversão.
Desafios
Crie na sua aplicação a opção de converter as moedas dólar ( $ ), euro ( € ), iene ( ¥ ) e libra esterlina ( £ ) em real ( R$ ).
Permita que o usuário informe qualquer uma das moedas (real , dólar, euro, iene ou libra esterlina) e depois converta pra qualquer uma das opções restantes.

## 6. Jogo da Forca <a name="Calculadora"></a>
Objetivo: usando uma aplicação do tipo console do dotnet, criar um jogo da forca que irá ler uma lista de nomes de filmes, nomes de jogos (vídeo game) e países. Com essa aplicação você poderá evoluir seus conhecimentos sobre manipulação de strings e leitura e escrita de arquivos.

Novos conceitos ou funcionalidades desse exercício
Gravação e leitura de arquivos para armazenar os nomes de filmes, carros e países.

Estude:

Gravação e leitura de arquivos.
Orientação a objetos (encapsulamento, herança, abstração e polimorfismo).
Caso não conheça os conceitos de orientação a objetos, pause um pouco a execução do exercício, estude esses conceitos e coloque-os em prática em alguns exemplos, pois no próximo exercício aprofundaremos em orientação a objetos.

Requisitos da aplicação
Ao abrir a aplicação o sistema deverá sortear aleatoriamente uma das 3 categorias: filmes, carros ou países e, após isso, sortear um dos nomes da categoria selecionada.

Após a seleção feita pelo sistema, exiba um placar na tela com a quantidade de tentativas disponíveis e quantas tentativas já foram realizadas. Nesse mesmo placar crie uma lista com as letras e números já utilizados pelo jogador.

Mostre na tela também, a categoria sorteada e a quantidade de letras da palavra. Além da quantidade de letras, inicialmente todas as letras da palavra devem ser substituídas por underline (_). Exemplo:

Se a palavra for o filme Matrix, deverá ser exibido 6 underline no lugar da palavra.
Ao acertar a letra A, deverá ser exibido apenas a letra a na posição correta.
As palavras devem ficar armazenadas em um arquivo de texto do tipo CSV que terá a palavra seguido pela categoria, onde Filme = 0, Jogo = 1, e Pais = 2. Segue um exemplo de como cada tipo deve ficar no arquivo:

Matrix;0;
Batman;1;
Brasil;2;
Se alguma palavra possui letra com acentuação, ela deve ser reconhecida quando o usuário informar sem acentuação, além disso a aplicação não deve diferenciar maiúsculo de minúsculo. Estude como usar o System.Text.Encoding.CodePages para remoção de acentos usando o 'ISO-8859-8'.

A cada tentativa atualize o placar com as pontuações.

Caso o jogador a 0 no número de tentativas exiba a mensagem "Fim de jogo, você perdeu!".

Caso o jogador acerte todas as letras, exiba a mensagem "Fim de jogo, você venceu!".

Opcional

Fazer o controle de versionamento da sua aplicação usando git;
Subir a aplicação para um repositório do github.
Faça o uso de todos os pilares da programação Orientada a Objetos.
Utilize Enumeradores para a categoria das palavras.
Estude o tratamento de erros com C# (Exceptions).
Estude a biblioteca System.Linq; para facilitar sua manipulação de listas.
Desafios
Crie mais uma categoria para o jogo dê sua preferência.
Antes de iniciar o jogo dê a opção de o usuário escolher a dificuldade do jogo: fácil, normal ou difícil:
Fácil: 7 tentativas
Normal: 6 tentativas
Difícil: 5 tentativas

## 7. Tabuada
[23:13]
Objetivo: usar uma aplicação do tipo console; criar uma aplicação que imprima a tabuada de 0 Zero a 10 de um número requisitado. 

Estudar:

Loop com For ou Whille

Requisitos:

Ao abrir a aplicação ele deve solicitar a tabuda de qual número dever ser impressa de 0 a 10. Por exemplol, se o usuário escolher a tabuada do dois (2) a aplicação deve imprimir a debuada do 2 (dois) da seguinte forma:

A tabuada solicitada foi: 2

2 x 0 = 0
2 x 1 = 2
2 x 2.=4
..... até 
2x 10 = 2

## 8.  Faça um programa para calcular o estoque médio de uma peça, sendo que:
ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2.

## 9.  Faça um programa que:
* Leia a cotação do dólar
* Leia um valor em dólares
* Converta esse valor para Real
* Mostre o resultado

## 10. Faça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração que sua
comissão será de 5% do total da venda e que você tem os seguintes dados:
- Identificação do vendedor
- Código da peça
- Preço unitário da peça
- Quantidade vendida

## 11. Caixa Eletronico. Faça uma aplicação que atenda a seguinte lista de requisitos, podem complementar funcionalidades de acordo com a sua criatividade, no entanto os requisitos mínimos deve ser atendidos.
- Deve ser desenvolvido completamente Orientado a Objetos utilizando as melhores práticas dos 4 pilares de Orientação a Objetos: Herança, Abstração, Polimorfisto e Encapsulamento
- Utilizar Generalização, Interface para assinatura de comportamentos (somente metodos),
- Função Deposito: 1) deve ser possivel depositar notas de R$ 10,00 / R$ 20,00 / R$  50,00 / R$  100,00 / R$  e 200,00 para Real(BRL) e moedas de R$ 0,01, R$ 0,05 /  R$ 0,10 / R$ 0,25 / R$ 0,50 / R$ 1,00 para Real(BRL).     2) deve ser possível depositar notas de $2, $5, $10, $20, $50 e $100 Dollar Americano (USD) e moedas  $0.01 / $0.05 / $0.10 /$0.25 /$0.50 /$1.00 Dollar Americano (USD).
- O caixa eletronico deve registrar a cotação de cambio do dia para conversão de moedas
- O caixa eletrônico deve dar troca na moeda original não convertida no cambio. Por exemplo: Ao depositar real e sacar dollar, o troco deve ser dados em real 
- caso o caixa eletronico não tenha mais moedas ou notas para entregar como troco, o troco pode ser dados em transfer6encia via PIX, TED ou numa wallet pra o cliente dentro do caixa eletronico em uma conta específica do cliente
- o cliente deve se cadastrar com os seguintes dados: Nome Completo, CPF, e uma senha de 4 números que nao pode ser 0000 nem 9999 e nem 1111
- O caixa eletronico deve dar suporte adicional a mais duas moedas e conseguir fazer cambio entre elas. Segue lista, escolhe até duas moedas desta lista: Peso Argentino, Euro, Dollar Canadense, Peso Mexicano,  Lira Turca ou Cedi Ganês 
- O caixa eletronico, alem de cambio deve permitir funcoes somente Saque, Somente Deposito em qualquer moeda
- eh possivel fazer camboi comprando com o cartào de crédito. No caso de compra de moeda com cartão a taxa de Cambio. eh de 8%, onde esse 8% cobrado fica como dinheiro eletronico que pode ser utilizado como troco em operações de PIX e TED
- toda operacão tem taxa. Segue: Cambio com Cartão 8%, Deposito 0%, Saque 4,5%, Cambio (compra de moeda utilizando deposito) 6%
- toda cobraça de taxa fica para o banco
- todas as taxas devem ser convertidas em reais e salva em uma conta específica do banco. Ou seja, o banco só salva valores em reais em suas contas bancárias (isso eh uma regra muito forte)
- Será possivel tirar relatórios: Quantas operações foram efetuadas por tipo? Quanto de taxa o banco já tem em sua conta? Qual o valor de saldo em cada conta corrente dos clientes? Quanto tem dentro do caixa eletronico em Notas e Moedas por tipo de Moeda (BRL,USD, etc...)
- O caixa eletronico tem uma opcão de carga de notas e moedas por tipo (BRL,USD, etc.....). Mas tudo tem limite, o caixa eletrônico só pode armazenar 20000 notas e 50000 moedas independente do tipo de moeda.Esse eh um limite de armazenagem físico mesmo.
- As notas e moedas depositadas pelos clientes também podem ser utilizadas para saque, mas cuidado com o limite.

## 12. Controle de Estoque. Faça uma aplicação que atenda os seguintes requisitos

* É um sistema de vendas de caixa, que tem acesso direto ao estoque de itens da loja
* todo item cadastrado deve ter pelo menos os seguintes atributos: numero do lote, data fabricaçao, quantidade em estoque e  data de vencimento
* criar metodo de entrada de estoque para adicionar e remover itens do estoque
* Processo de venda: os itens deve ser associados a um numero de pedido
* O cliente deve conseguir obter o detalghes dos itens no carrinho de compra e o valor total da compra antes de finalizar no caixa
* Quando a venda for concluida a quantidade do item deve ser removida do estoque e grada uma nota fiscal na tela do operador
* o pagamento pode ser parcelado ou a vista no debito e cartao de credito
* se o cartao de debito for utlizado para a compra ou ela ter sido feita no dinheiro, o cliente deverá receber de 10% 12% 14% 17% ou 20% de desconto
* os valores de desconto só deverão ser aplicados em compras a cima de 300 reais, e também um dos descontos de 10% 12% 14% 17% ou 20% de desconto deve ser escohido via sorteio que acontece no momento da confirmação do pagamento
