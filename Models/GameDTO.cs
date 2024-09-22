using System.ComponentModel.DataAnnotations;
namespace TetrisServer.Models;

public class GameDTO
{
	public string? UserName { get; set; }
	public int Score { get; set; }
}