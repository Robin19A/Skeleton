USE [p2763923]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblOrder_SelectAll]

SELECT	@return_value as 'Return Value'

GO
