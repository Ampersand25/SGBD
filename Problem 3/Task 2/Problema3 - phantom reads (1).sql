USE [Problema3]
GO

CREATE OR ALTER PROCEDURE [dbo].[PhantomReads1Problema3]
AS
BEGIN
	BEGIN TRAN -- BEGIN TRANSACTION
	WAITFOR DELAY '00:00:05'
	INSERT INTO [Problema3].[dbo].[Biscuiti] ([nume_b], [nr_calorii], [pret], [cod_p]) VALUES
	('biscuiti cu mar si scortisoara', 90, 4.99, 2)
	COMMIT TRAN -- COMMIT TRANSACTION
END

GO

EXEC [dbo].[PhantomReads1Problema3]