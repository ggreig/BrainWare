CREATE PROCEDURE [dbo].[getcompanyorders]
	@companyId int = 0
AS
	SELECT c.name, o.description, o.order_id 
	FROM Company c INNER JOIN [Order] o on c.company_id=o.company_id
	WHERE c.company_id = @companyId
RETURN 0
