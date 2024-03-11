using auction.API.Contracts;
using auction.API.Entities;
namespace auction.API.Repositories.DataAccess;

public class UserRepository : IUserRepository
{
    private readonly auctionDbContext _dbContext;
    public UserRepository(auctionDbContext dbContext) => _dbContext = dbContext;

    public bool ExistUserWithEmail(string email)
    {
        return _dbContext.Users.Any(user => user.Email.Equals(email));
    }

    public User GetUserByEmail(string email) => _dbContext.Users.First(user => user.Email.Equals(email));
    

}
