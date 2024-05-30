USE [p2763923]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblSupplier_FilterBySupplierId]
		@SupplierId = 2

SELECT	@return_value as 'Return Value'

GO
