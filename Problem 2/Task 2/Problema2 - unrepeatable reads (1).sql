USE [Problema2]
GO

SELECT * FROM [Problema2].[dbo].[Artisti]

GO

CREATE OR ALTER PROCEDURE [dbo].[UnrepeatableReads1Problema2]
AS
BEGIN
	INSERT INTO [Problema2].[dbo].[Melodii] ([titlu], [an_lansare], [durata], [cod_artist]) VALUES
	('Futureproof', 1999, '00:04:09', 3)

	BEGIN TRAN -- BEGIN TRANSATION
	WAITFOR DELAY '00:00:05'
	UPDATE [Problema2].[dbo].[Melodii] SET [an_lansare] = 2015, [durata] = '00:03:27', [cod_artist] = 1 WHERE [titlu] = 'Futureproof'
	COMMIT TRAN -- COMMIT TRANSATION
END

GO

EXEC [dbo].[UnrepeatableReads1Problema2]