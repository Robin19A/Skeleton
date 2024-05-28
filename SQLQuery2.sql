USE [p2763923]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sporc_tblStaff_SelectAll]

SELECT	@return_value as 'Return Value'

GO
