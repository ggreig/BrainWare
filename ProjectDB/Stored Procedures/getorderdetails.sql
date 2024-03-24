CREATE PROCEDURE [dbo].[getorderdetails]
	@companyId int = 0
AS
SELECT op.price, op.order_id, op.product_id, op.quantity, p.name, p.price
	FROM   orderproduct AS op 
		   INNER JOIN Product AS p ON op.product_id = p.product_id 
		   INNER JOIN Company AS c 
		   INNER JOIN [Order] AS o ON c.company_id = o.company_id ON op.order_id = o.order_id
	WHERE c.company_id = @companyId
RETURN 0
