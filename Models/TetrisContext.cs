using Microsoft.EntityFrameworkCore;

namespace TetrisServer.Models;

public class TetrisContext : DbContext
{
    public TetrisContext(DbContextOptions<TetrisContext> options)
        : base(options)
    {
    }

    public DbSet<Game> Games { get; set; } = null!;
}