CREATE PROCEDURE [MINIMAL_API_DEMO].[spUser_GetAll]
AS begin
	select
		Id,
		FirstName,
		LastName
	from MINIMAL_API_DEMO.[User]
end