USE [Problema3]
GO

CREATE OR ALTER PROCEDURE [dbo].[PhantomReads2Problema3]
@solve BIT
AS
BEGIN
	IF @solve = 0
		-- PROBLEM:
		SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
	ELSE
		-- SOLUTION:
		SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
	
	BEGIN TRAN -- BEGIN TRANSACTION
	SELECT * FROM [Problema3].[dbo].[Biscuiti]
	WAITFOR DELAY '00:00:10'
	SELECT * FROM [Problema3].[dbo].[Biscuiti]
	COMMIT TRAN -- COMMIT TRANSACTION
END

GO

-- CALL FOR PROBLEM
EXEC [dbo].[PhantomReads2Problema3] 0

-- CALL FOR SOLUTION
EXEC [dbo].[PhantomReads2Problema3] 1

SELECT * FROM [Problema3].[dbo].[Biscuiti]
DELETE FROM [Problema3].[dbo].[Biscuiti] WHERE [nume_b] = 'biscuiti cu mar si scortisoara'
select * from [Problema3].[dbo].[Biscuiti]