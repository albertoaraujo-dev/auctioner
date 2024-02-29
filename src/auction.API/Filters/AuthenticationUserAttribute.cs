using auction.API.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace auction.API.Filters;

public class AuthenticationUserAttribute : AuthorizeAttribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var token = TokenOnRequest(context.HttpContext);

        var repository = new auctionDbContext();
    }

    private string TokenOnRequest(HttpContext context)
    {
        var authentication = context.Request.Headers.Authorization.ToString();

        if(string.IsNullOrEmpty(authentication))
        {
            throw new Exception("Token is missing");
        }

        // authentication[7..] "Y3Jpc3RpYW5vQGNyaXN0aWFuby5jb20="
        return authentication["Bearer ".Length..];
    }
}
