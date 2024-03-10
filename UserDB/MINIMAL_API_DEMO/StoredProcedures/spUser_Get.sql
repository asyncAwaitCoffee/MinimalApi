CREATE PROCEDURE [MINIMAL_API_DEMO].[spUser_Get]
	@Id int
AS begin
	select
		Id,
		FirstName,
		LastName
	from MINIMAL_API_DEMO.[User]
	where Id = @Id;
end
