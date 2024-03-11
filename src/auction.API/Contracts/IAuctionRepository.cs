using auction.API.Entities;

namespace auction.API.Contracts;

public interface IAuctionRepository
{
    Auction? GetCurrent();
}
