CREATE PROCEDURE [MINIMAL_API_DEMO].[spUser_Update]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS begin
	update MINIMAL_API_DEMO.[User]
	set FirstName = @FirstName,
		LastName = @LastName
	where Id = @Id
end