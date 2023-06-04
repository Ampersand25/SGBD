USE [Problema1]
GO

DELETE FROM [Problema1].[dbo].[Briose] WHERE [nume_briosa] = 'briosa cu zmeura si menta'

INSERT INTO [Problema1].[dbo].[Briose] ([nume_briosa], [descriere], [pret], [cod_cofetarie]) VALUES
('briosa cu zmeura si menta', 'briosa clasica cu gust de mere si infuzie de menta', 10, 2)

SELECT * FROM [Problema1].[dbo].[Briose]

GO

CREATE OR ALTER PROCEDURE [dbo].[DirtyReads1Problema1]
AS
BEGIN
	BEGIN TRAN -- BEGIN TRANSATION
	UPDATE [Problema1].[dbo].[Briose] SET [pret] = 15, [cod_cofetarie] = 3 WHERE [nume_briosa] = 'briosa cu zmeura si menta'
	WAITFOR DELAY '00:00:05'
	ROLLBACK TRAN -- ROLLBACK TRANSATION
END

GO

EXEC [dbo].[DirtyReads1Problema1]