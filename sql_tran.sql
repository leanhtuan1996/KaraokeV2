CREATE PROC [dbo].[sp_GetMenu_ThemDV]
AS
BEGIN
	SELECT name FROM dbo.Menu WHERE status = 1 GROUP BY name
END
GO