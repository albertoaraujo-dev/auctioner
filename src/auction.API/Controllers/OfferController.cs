using auction.API.Communication.Requests;
using auction.API.Filters;
using auction.API.UseCases.Offers.CreateOffer;
using Microsoft.AspNetCore.Mvc;

namespace auction.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : auctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    
    public IActionResult CreateOffer(
        [FromRoute] int itemId, 
        [FromBody] RequestCreateOfferJson request,
        [FromServices] CreateOfferUseCase useCase)
    {
        var id = useCase.Execute(itemId, request);

        return Created(string.Empty, id);
    }
}
