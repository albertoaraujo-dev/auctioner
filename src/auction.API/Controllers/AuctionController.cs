﻿using auction.API.Entities;
using auction.API.UseCases.Auctions.GetCurrent;
using Microsoft.AspNetCore.Mvc;

namespace auction.API.Controllers;


public class AuctionController : auctionBaseController
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrentAuction()
    {
        var useCase = new GetCurrentAuctionUseCase();

        var result = useCase.Execute();

        if (result is null)
            return NoContent();

        return Ok(result);
    }
}

