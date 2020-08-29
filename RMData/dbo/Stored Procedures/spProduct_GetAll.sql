CREATE PROCEDURE [dbo].[spProduct_GetAll]
AS
begin
	set nocount on;

	select Id, [Name], [Description], RetailPrice, QuantityInStock, IsTaxable
	from dbo.Product
	order by [Name];
end

