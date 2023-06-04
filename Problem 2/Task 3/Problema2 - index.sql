USE [Problema2]
GO

DROP INDEX IF EXISTS idx_Artisti_nume_artist ON [Problema2].[dbo].[Artisti]

CREATE INDEX idx_Artisti_nume_artist ON [Problema2].[dbo].[Artisti] ([nume_artist] DESC)

SELECT [nume_artist] AS 'Nume complet artist'
FROM [Problema2].[dbo].[Artisti]
ORDER BY [nume_artist] DESC