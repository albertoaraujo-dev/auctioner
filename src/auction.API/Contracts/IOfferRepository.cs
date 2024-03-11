using auction.API.Entities;

namespace auction.API.Contracts;

public interface IOfferRepository
{
    void Add(Offer offer);
}
