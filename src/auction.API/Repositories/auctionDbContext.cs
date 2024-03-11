using auction.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace auction.API.Repositories;

public class auctionDbContext : DbContext
{
    public auctionDbContext(DbContextOptions options) : base(options) { }
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<Offer> Offers { get; set; }
    public DbSet<User> Users { get; set; }

}
