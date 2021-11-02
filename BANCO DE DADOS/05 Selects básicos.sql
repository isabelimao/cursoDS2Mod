
--Comando SELECT FROM(Selecionar De)
--Estrutura b�sica: Select <campos> from <tabela> 

--Selecionar todos os campos das tabelas:
SELECT * FROM Clientes
SELECT * FROM Vendedor
SELECT * FROM Produtos
SELECT * FROM NF
SELECT * FROM ItensNF
SELECT * FROM Estado

--Cl�usula WHERE (Onde)
--Selecionar todos os campos da tabela Clientes onde o estado 
--for igual a DF
--Quando for especificar campos do tipo texto, 
--utilizar aspas simples
SELECT * 
FROM Clientes 
WHERE Estado = 'DF'

--Operador Like (como), utilizado em substitui��o ao "=" 
--quando quiser citar parte do campo
--Utilizar o s�mbolo de % para completar a palavra. 
--Pode ser utilizado no in�cio ou fim da condi��o
--Selecionar todos os campos da tabela Clientes onde a cidade 
--come�ar com Rio ou S�o
SELECT * FROM Clientes WHERE Cidade like 'Rio %' or Cidade like 'S�o %'

--Operador != (Diferente)
--Selecionar todos os campos da Tabela Vendedores 
--onde o estado for diferente de DF
SELECT * FROM Vendedor WHERE Estado != 'DF'

--Escolhendo os campos:
--Selecionar os campos nome, cidade, estado e cep da 
--tabela Vendedor onde estado = 'DF'
SELECT nome, cidade, estado, cep 
FROM Vendedor 
--WHERE Estado = 'DF'



--Cl�usula ORDER BY (Ordenado por)
--Selecionar todos os campos da tabela Clientes 
--ordenados pelo campo nome
SELECT * FROM Clientes ORDER BY nome 

--Operador >= (Maior igual a)
--Selecionar todos os campos da tabela Clientes onde o nome 
--for maior ou igual a m
SELECT * 
FROM alunos 
WHERE nome >= 'Leticia' and curso = 'DS' and turma='2 modulo'

--Selecionar todos os campos da tabela Clientes onde o nome 
--for maior ou igual a mo, ordenados pelo campo nome descendente
SELECT * 
FROM Clientes 
WHERE nome >= 'mo' 
ORDER BY nome DESC
--pode ter mais de um campo de ordena��o
SELECT * 
FROM Clientes 
WHERE nome >= 'm' and cidade>='M'
ORDER BY estado , cidade , BAIRRO 
-- DESC ordena descendente
SELECT * 
FROM Clientes 
ORDER BY estado desc, cidade desc, BAIRRO desc


--Alias AS = COMO
SELECT NOME AS 'NOME DO CLIENTE', Telefone as 'Telefone do cliente'
  FROM CLIENTES 
ORDER BY 'NOME DO CLIENTE'


--Fun��o de Agrega��o Count (Contar)
--Cl�usula Group By (Agrupado por)
--Exiba a quantidade de vendedores da tabela vendedores agrupados por estado
select estado, count(*) as qtde_vendedores from vendedor group by estado

--CONTAR
SELECT COUNT(*) AS QTDE_VENDEDORES FROM VENDEDOR
SELECT COUNT(*) AS QTDE_CLIENTES FROM CLIENTES

SELECT ESTADO, CIDADE, COUNT(*)AS QTDE_DE_VENDEDORES
FROM VENDEDOR
GROUP BY ESTADO, CIDADE
ORDER BY estado, CIDADE DESC

SELECT ESTADO, COUNT (*) 
AS QTDE_DE_VENDEDORES
FROM Vendedor	
GROUP BY Estado

--SELECIONA A QUANTIDADE DE CLIENTES POR ESTADO
SELECT ESTADO, CIDADE, BAIRRO, COUNT (*) AS QTDE_DE_CLIENTES
FROM Clientes	
GROUP BY Estado, cidade, BAIRRO
ORDER BY estado, cidade, BAIRRO

--SELECIONA O PRE�O M�XIMO
SELECT MAX(PRECO_UNIT) AS PRECO_MAXIMO FROM PRODUTOS

--SELECIONA O PRE�O M�NIMO
SELECT MIN(PRECO_UNIT) AS PRECO_MINIMO FROM PRODUTOS

--SELECIONA O PRE�O M�DIO
SELECT AVG(PRECO_UNIT) AS PRECO_MEDIO FROM PRODUTOS

--SOMA OS PRE�OS
SELECT SUM(PRECO_UNIT) AS SOMA FROM PRODUTOS

--SELECIONAR O PRE�O M�XIMO, M�NIMO E M�DIO 
--E CONTAR AGRUPADOS POR CATEGORIA DE PRODUTO
SELECT CATEGORIA, 
MAX(PRECO_UNIT) AS PRECO_MAXIMO,
MIN(PRECO_UNIT) AS PRECO_MINIMO,
AVG(PRECO_UNIT) AS PRECO_MEDIO,
COUNT(CATEGORIA) AS QTDE
FROM Produtos
GROUP BY CATEGORIA


--Exiba a quantidade de vendedores e o estado da tabela vendedores
-- agrupado por estado
SELECT COUNT (codigo) as qtde, estado 
FROM Vendedor 
GROUP BY Estado

-- Selecionar os 5 produtos mais caros
Select top 100 preco_unit, descri��o 
  from produtos as p 
 order by preco_unit desc

--Contando cds 
 SELECT COUNT(codigo)as Qtde_de_cds FROM Produtos
 
--Contando cds por categoria
SELECT Qtde_por_categoria=COUNT(codigo), Categoria 
  FROM Produtos
group by Categoria
ORDER BY Categoria

--Selecionar os produtos que possuem 
--pre�o unit�rio maior que R$ 10,00
SELECT * 
  FROM produtos
 WHERE preco_unit >= 10

--Utiliza��o de Case
--Criar uma faixa de pre�os baseada no pre�o do produto
SELECT   Codigo, Descri��o, Categoria, 
  CASE 
   WHEN Preco_Unit <= 20 THEN ' 0,00 a 20,00'
   WHEN Preco_Unit <= 30 THEN '20,00 a 30,00'
   Else 'Acima de 30,00'
  END  AS  'Faixa de Pre�o'  
FROM Produtos
ORDER BY 'Faixa de Pre�o' 

--Criar uma classifica��o baseada na categoria do produto
Select descri��o, classificacao=
case 
	when categoria = 'rock' or categoria = 'rock/pop' then 'legal'
	when categoria = 'pop' then 'm�dio'
	else 'chato'
end 
from produtos




