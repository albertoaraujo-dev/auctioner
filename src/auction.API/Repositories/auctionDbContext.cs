using auction.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace auction.API.Repositories;

public class auctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=C:\Users\Alberto\Documents\Dev\Projetos\csharp\auction\leilaoDbNLW.db");
    }
}
