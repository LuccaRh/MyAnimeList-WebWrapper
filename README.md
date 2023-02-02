# MyAnimeList-WebWrapper
## Resumo
Programa que Busca informações dos animes mais bem avaliados do site [MyAnimeList](https://myanimelist.net/topanime.php), coleta e armazena essas informações, 
e depois as guardam num banco de dados SQL.
## Como Funciona
1. É feito um forloop para a quantidade de páginas do site que serão vistas, em que cada página possui 50 animes.
2. Utilizando a biblioteca **HtmlAgilityPack**, é pego os links de todas páginas individuais de cada anime (pelo nome deles), que são guardados em uma lista.
3. É obtido o título, score, rank, popularidade e quantidade de membros de cada anime pela página dele, e estas informações são guardadas num objeto com tal propriedades.
4. Utilizando as bibliotecas **Dapper** e **System.Data.SqlCliente**, uma conexão é feita com o banco de dados, e as informações do objeto são adicionadas numa tabela, com
as mesmas propriedades.

(Adicionar imagens do terminal e da tabela do banco de dados)

##Possíveis melhorias
* Escolher precisamente quantos animes serão vistos, e não ir em página por página, ou seja, 50 por 50 animes.
* Utilizar menos forloops, e tentar deixar o programa mais veloz.
* Utilizar os dados obtidos e guardados no SQL para algo, como por exemplo, MachineLearning.
* Uma lista de objetos com as informações de cada anime é criada durante a execução do programa, contendo todos os animes nela, mas não é feito nada com nela, logo, achar
algo para fazer com ela, ou simplismente deleta-lá.
