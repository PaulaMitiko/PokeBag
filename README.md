# PokeBag
Nada melhor que aprender C# com Pokémon &lt;3

Objetivo: Criar um gerenciador de Bag de Pokémons no jogo Pokémon Go. Para isso é necessário criar as seguintes funcionalidades:\
-adicionar pokémons capturados à base de dados;\
-excluir pokémons transferidos da base de dados;\
-indicar pokémons para troca, obedecendo os critérios listados abaixo;\
-indicar pokémons para serem transferidos, obedecendo os critérios listados abaixo.

DER: https://app.lucidchart.com/invitations/accept/5e8c3831-0e08-4336-99b6-a6f244c8e31e

Descrição das tabelas:\
-Bag: É a tabela principal. Nela temos todas as informações de cada pokémon capturado.\
-PokeDex: Contém informações de cada espécie de pokemon (informações retiradas do https://www.serebii.net/pokemongo/pokemon/). <br/>
-Cidade: Contém informações da cidade em que o pokemon foi capturado. 

Critérios:\
-Deve ser mantido pelo menos um pokemon de cada cidade registrada;\
-Deve ser mantido pelo menos um pokemon de cada espécie registrada;\
-Todos os pokemons shinys devem ser mantidos;\
-Pelo menos um exemplar sombroso e um exemplar purificado devem ser mantidos para cada espécie registrada;\
-Pelo menos um exemplar de cada evento deve ser mantido para cada espécie de pokémon;\
-Pokémons com IV (Individual Value) inferior a 40% e CP (Combat Point) próximo ao máximo são mantidos para troca;\
-Pokémons com IV acima de 90% são mantidos, independente do CP;\
-Pokémons com IV entre 40 e 90%  serão mantidos caso tenham CP máximo. 

Ideias para melhorias:\
-Seleção de counters para batalhas.
