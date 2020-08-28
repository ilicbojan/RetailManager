CREATE PROCEDURE [dbo].[spProduct_GetAll]
AS
begin
	set nocount on;

	select Id, [Name], [Description], RetailPrice, QuantityInStock
	from dbo.Product
	order by [Name];
end

