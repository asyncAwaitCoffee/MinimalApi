﻿namespace MinimalAPIDemo;

public static class Api
{
	public static void ConfigureApi(this WebApplication web)
	{
		web.MapGet("/users", GetUsers);
		web.MapGet("/users/{id}", GetUser);
		web.MapPost("/users", InsertUser);
		web.MapPut("/users", UpdateUser);
		web.MapDelete("/users", DeleteUser);
	}

	private static async Task<IResult> GetUsers(IUserData data)
	{
		try
		{
			return Results.Ok(await data.GetUsers());
		}
		catch (Exception ex)
		{

			return Results.Problem(ex.Message);
		}
	}

	private static async Task<IResult> GetUser(int id, IUserData data)
	{
		try
		{
			var results = await data.GetUser(id);
			if (results == null) return Results.NotFound(id);
			return Results.Ok(results);
		}
		catch (Exception ex)
		{

			return Results.Problem(ex.Message);
		}
	}

	private static async Task<IResult> InsertUser(UserModel user, IUserData data)
	{
		try
		{
			await data.InsertUser(user);
			return Results.Ok();
		}
		catch (Exception ex)
		{

			return Results.Problem(ex.Message);
		}
	}

	private static async Task<IResult> UpdateUser(UserModel user, IUserData data)
	{
		try
		{
			await data.UpdateUser(user);
			return Results.Ok();
		}
		catch (Exception ex)
		{

			return Results.Problem(ex.Message);
		}
		
	}

	private static async Task<IResult> DeleteUser(int id, IUserData data)
	{
		try
		{
			await data.DeleteUser(id);
			return Results.Ok();
		}
		catch (Exception ex)
		{

			return Results.Problem(ex.Message);
		}
	}
}