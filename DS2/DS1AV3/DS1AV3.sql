
CREATE PROCEDURE AtualizarCliente
(
@id int,
@nome varchar(50),
@endereco varchar(50),
@telefone varchar(50),
@email varchar(50)
)
as
	UPDATE	[dbo].[Clientes]
		SET [nome] = @nome
		,[endereco] = @endereco
		,[telefone] = @telefone
		,[email] = @email
		WHERE id=@id;
GO
