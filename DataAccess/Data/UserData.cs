using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;
public class UserData : IUserData
{
	private readonly ISqlDataAccess _db;

	public UserData(ISqlDataAccess db)
	{
		_db = db;
	}

	public Task<IEnumerable<UserModel>> GetUsers() =>
		_db.LoadData<UserModel, dynamic>("[MINIMAL_API_DEMO].[spUser_GetAll]", new { });

	public async Task<UserModel?> GetUser(int id)
	{
		var results = await _db.LoadData<UserModel, dynamic>(
			"[MINIMAL_API_DEMO].[spUser_Get]",
			new { Id = id }
			);

		Console.WriteLine(results.FirstOrDefault()?.FirstName.Length);
		Console.WriteLine(results.FirstOrDefault()?.LastName.Length);

		return results.FirstOrDefault();
	}

	public Task InsertUser(UserModel user) =>
		_db.SaveData("[MINIMAL_API_DEMO].[spUser_Insert]", new { user.FirstName, user.LastName });

	public Task UpdateUser(UserModel user) =>
		_db.SaveData("[MINIMAL_API_DEMO].[spUser_Update]", user);

	public Task DeleteUser(int id) =>
		_db.SaveData("[MINIMAL_API_DEMO].[spUser_Delete]", new { Id = id });
}
