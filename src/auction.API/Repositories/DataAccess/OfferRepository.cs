using auction.API.Contracts;
using auction.API.Entities;

namespace auction.API.Repositories.DataAccess;

public class OfferRepository : IOfferRepository
{

    private readonly auctionDbContext _dbContext;
    public OfferRepository(auctionDbContext dbContext) => _dbContext = dbContext;
    public void Add(Offer offer)
    {
        _dbContext.Offers.Add(offer);

        _dbContext.SaveChanges();
    }
}
