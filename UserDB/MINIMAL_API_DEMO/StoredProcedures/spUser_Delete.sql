CREATE PROCEDURE [MINIMAL_API_DEMO].[spUser_Delete]
	@Id int
AS begin
	delete
	from MINIMAL_API_DEMO.[User]
	where Id = @Id;
end
