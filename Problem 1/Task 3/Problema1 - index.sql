USE [Problema1]
GO

DROP INDEX IF EXISTS idx_Briose_nume_briosa_pret ON [Problema1].[dbo].[Briose]

CREATE INDEX idx_Briose_nume_briosa_pret ON [Problema1].[dbo].[Briose] ([nume_briosa] DESC, [pret] ASC)

SELECT [nume_briosa] AS 'Nume briosa', [Pret curent briosa] = [pret]
FROM [Problema1].[dbo].[Briose]
WHERE [pret] < 10
ORDER BY [nume_briosa] DESC, [pret] ASC