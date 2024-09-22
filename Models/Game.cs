using System.ComponentModel.DataAnnotations;
namespace TetrisServer.Models;

public class Game
{
	[Key]
	public Guid GameId { get; set; }
	public string? UserName { get; set; }
	public int Score { get; set; }
}