--1
SELECT 
Nome, Ano
FROM Filmes
--2 (Não pediu duração, mas consta na imagem)
SELECT 
Nome, Ano, Duracao
FROM Filmes 
ORDER BY Ano ASC
--3
SELECT 
Nome, Ano, Duracao
FROM Filmes 
WHERE Nome = 'De Volta para o Futuro'
--4
SELECT 
Nome, Ano, Duracao
FROM Filmes 
WHERE Ano = 1997
--5
SELECT 
Nome, Ano, Duracao
FROM Filmes 
WHERE Ano > 2000
--6
SELECT 
Nome, Ano, Duracao
FROM Filmes 
WHERE Duracao > 100 AND Duracao < 150
ORDER BY Duracao ASC
--7 (Pediu para ordenar pela duração, mas no exemplo está ordenando por Quantidade)
SELECT 
Ano, 
COUNT(*) as Quantidade
FROM Filmes 
GROUP BY Ano
ORDER BY Quantidade DESC
--8
SELECT 
PrimeiroNome, 
UltimoNome, 
Genero 
FROM Atores
WHERE Genero = 'M'
--9
SELECT 
PrimeiroNome, 
UltimoNome, 
Genero 
FROM Atores
WHERE Genero = 'F'
ORDER BY PrimeiroNome ASC
--10
SELECT 
Nome, 
Genero
FROM Generos 
INNER JOIN FilmesGenero ON Generos.Id = FilmesGenero.IdGenero
INNER JOIN Filmes ON FilmesGenero.IdFilme = Filmes.Id
--11
SELECT 
Nome, 
Genero
FROM Generos 
INNER JOIN FilmesGenero ON Generos.Id = FilmesGenero.IdGenero
INNER JOIN Filmes ON FilmesGenero.IdFilme = Filmes.Id
WHERE Generos.Genero = 'Mistério'
--12
SELECT 
Nome,
PrimeiroNome,
UltimoNome,
Papel
FROM Filmes 
INNER JOIN ElencoFilme ON Filmes.Id = ElencoFilme.IdFilme
INNER JOIN Atores ON Atores.Id = ElencoFilme.IdAtor

