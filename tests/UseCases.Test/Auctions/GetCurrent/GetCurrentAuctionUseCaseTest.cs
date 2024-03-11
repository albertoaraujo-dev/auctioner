using auction.API.UseCases.Auctions.GetCurrent;
using FluentAssertions;
using Xunit;

namespace UseCases.Test.Auctions.GetCurrent;
public class GetCurrentAuctionUseCaseTest
{
    [Fact]
    public void Success()
    {

        //ARRANGE
        var useCase = new GetCurrentAuctionUseCase(null);

        //ACT
        var auction = useCase.Execute();

        //ASSERT
        auction.Should().NotBeNull();

    }
}
