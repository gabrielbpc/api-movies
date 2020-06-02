# api-movies

Pra obtenção dos dados via HTTP GET deve ser utilizada a API abaixo :

- URL: https://imdb8.p.rapidapi.com/title/get-videos
- Parametros: 

Key	Value
limit	25
region	PT
tconst	tt0944947

- Headers: 

Key	Value
x-rapidapi-host	imdb8.p.rapidapi.com
x-rapidapi-key	662179b8efmshc9ef6bc611aa329p1e2dc0jsn0556aee23b54
useQueryString	true

A API deve conter os seguintes endpoints :

- (GET) /api/movies : Retorna uma lista dos vídeos utilizando os dados fornecidos acima e grava a lista num arquivo JSON. Cada vídeo irá conter um elemento conforme o exemplo do JSON abaixo :

{
        "description": "\"Game of Thrones\" star Nikolaj Coster-Waldau defends Jaime Lannister and picks which character he think should sit atop the Iron Throne.",
        "primaryTitle": {
            "title": "Nikolaj Coster-Waldau",
            "year": "2019"
        }
}

- (POST) /api/movies : Inclui um video na lista de videos gerada no método GET, atualizando o arquivo JSON.
