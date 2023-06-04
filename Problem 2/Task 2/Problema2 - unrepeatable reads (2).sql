USE [Problema2]
GO

CREATE OR ALTER PROCEDURE [dbo].[UnrepeatableReads2Problema2]
@solve BIT
AS
BEGIN
	IF (@solve = 0)
		-- PROBLEM:
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED
	ELSE
		-- SOLUTION:
		SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
	
	BEGIN TRAN -- BEGIN TRANSATION
	SELECT * FROM [Problema2].[dbo].[Melodii]
	WAITFOR DELAY '00:00:10'
	SELECT * FROM [Problema2].[dbo].[Melodii]
	COMMIT TRAN -- COMMIT TRANSACTION
END

GO

-- CALL FOR PROBLEM
EXEC [dbo].[UnrepeatableReads2Problema2] 0

-- CALL FOR SOLUTION
EXEC [dbo].[UnrepeatableReads2Problema2] 1

SELECT * FROM [Problema2].[dbo].[Melodii]
DELETE FROM [Problema2].[dbo].[Melodii] WHERE [titlu] = 'Futureproof'
SELECT * FROM [Problema2].[dbo].[Melodii]