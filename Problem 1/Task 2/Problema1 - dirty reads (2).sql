USE [Problema1]
GO

CREATE OR ALTER PROCEDURE [dbo].[DirtyReads2Problema1]
@solve BIT
AS
BEGIN
	IF (@solve = 0)
		-- PROBLEM:
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
	ELSE
		-- SOLUTION:
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED

	BEGIN TRAN -- BEGIN TRANSATION
	SELECT * FROM [Problema1].[dbo].[Briose]
	WAITFOR DELAY '00:00:10'
	SELECT * FROM [Problema1].[dbo].[Briose]
	COMMIT TRAN -- COMMIT TRANSATION
END

GO

-- CALL FOR PROBLEM
EXEC [dbo].[DirtyReads2Problema1] 0

-- CALL FOR SOLUTION
EXEC [dbo].[DirtyReads2Problema1] 1

SELECT * FROM [Problema1].[dbo].[Briose]