using auction.API.Contracts;
using auction.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace auction.API.Repositories.DataAccess;

public class AuctionRepository : IAuctionRepository
{

    private readonly auctionDbContext _dbContext;
    public AuctionRepository(auctionDbContext dbContext) => _dbContext = dbContext;

    public Auction? GetCurrent()
    {

        var today = DateTime.Now;

        return _dbContext
            .Auctions
            .Include(auction => auction.Items)
           //.FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
            .FirstOrDefault(auction => today >= auction.Starts);
    }
}
