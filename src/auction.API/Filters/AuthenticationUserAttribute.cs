﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace auction.API.Filters;

public class AuthenticationUserAttribute : AuthorizeAttribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var token = TokenOnRequest(context.HttpContext);
    }

    private string TokenOnRequest(HttpContext context)
    {
        var authentication = context.Request.Headers.Authorization.ToString();

        //"Bearer Y3Jpc3RpYW5vQGNyaXN0aWFuby5jb20="

        // authentication[7..]
        return authentication["Bearer ".Length..];
    }
}
