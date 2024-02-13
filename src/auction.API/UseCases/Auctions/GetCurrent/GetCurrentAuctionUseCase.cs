using auction.API.Entities;
using auction.API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace auction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction? Execute() 
    {
        var repository = new auctionDbContext();

        var today = DateTime.Now;

        return repository
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }
}
