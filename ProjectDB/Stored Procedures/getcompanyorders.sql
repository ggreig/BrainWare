CREATE PROCEDURE [dbo].[getcompanyorders]
	@companyId int = 0
AS
	SELECT c.name, o.description, o.order_id 
	FROM company c INNER JOIN [order] o on c.company_id=o.company_id
	WHERE c.company_id = @companyId
RETURN 0
