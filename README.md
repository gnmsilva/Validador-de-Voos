# Validador-de-Voos

Projeto final (MAPA - Material de Avaliação Prática) para a matéria Algoritmos e Lógica de Programação 1 (ALP1).

A entrega foi realizada em pseudocódigo. Porém, foi refeito em C# a fim de praticar a linguagem.

A solicitação da atividade era:

" _Imagine que voce trabalhe na área de Tecnologia de uma companhia aérea de grande porte e foi solicitado a sua área que criasse um algoritmo para controle de abastecimento das aeronaves antes dos voos. Um Boeing 737-800 por exemplo, pode gastar em média 3,6 litros por km de voo. O gasto de uma aeronave de grande porte é tanto que a medição muda de eixo, sendo utilizado litros por quilômetros, diferente do que estamos acostumados a calcular nos automóveis que é quilômetros por litro. Um trecho de 1100km, como por exemplo de São Paulo a Porto Alegre precisaria de 3960 litros, sem contar a margem de segurança e outos fatores que podem alterar a quantidade._

_Para criação do algoritmo solicitado deverão ser considerados os seguintes dados para o calculo desejado, são eles:_

_- Média da aeronave em litros por quilômetros_

_- Capacidade máxima em litros do tanque_

_- Quantidade de quilômetros do trecho planejado_

_- Quantidade de quilômetros do trecho alternativo_

_- Quantidade de combustível já na aeronave_
    
_O algoritmo deve conter as seguintes regras:_

_- Uma aeronave deve sempre ser abastecida considerando o trecho planejado + trecho alternativo, visto que se o aeroporto de destino estiver com problemas, uma rota alternativa deverá ser realizada._

_- Além do trecho total, uma margem de 30% de combustível deverá ser adicionada, para que qualquer emergência a aeronave esteja com uma quantidade segura de combustível._

_- Se o trecho total mais a margem de segurança, extrapolarem a capacidade máxima de combustível do tanque da aeronave, uma mensagem de alerta deve ser mostrada na tela, dizendo a seguinte mensagem “Voo Reprovado, reveja seu planejamento.”. Caso contrário mostrar "Voo Aprovado, bom voo!"_

_- Se o tanque suportar o trecho total mais a margem de segurança o algoritmo deverá mostrar na tela o valor do trecho principal, trecho alternativo, total do trecho com a margem de segurança, quantidade de combustível necessária para o trecho e quantidade necessária de abastecimento._
