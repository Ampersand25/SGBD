USE [Problema3]
GO

DROP INDEX IF EXISTS idx_Biscuiti ON [Problema3].[dbo].[Biscuiti]

CREATE INDEX idx_Biscuiti ON [Problema3].[dbo].[Biscuiti] ([nume_b], [nr_calorii], [pret])

SELECT [nume_b] AS 'Nume biscuite', [Numar total de calorii] = [nr_calorii], [pret] AS [Pret biscuite (RON)]
FROM [Problema3].[dbo].[Biscuiti]
ORDER BY [nume_b]