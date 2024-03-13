using auction.API.Contracts;
using auction.API.Entities;

namespace auction.API.Services;

public class LoggedUser : ILoggedUser
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IUserRepository _repository;
    public LoggedUser(IHttpContextAccessor httpContext, IUserRepository repository)
    {
        _httpContextAccessor = httpContext;
        _repository = repository;

    }
    public User User()
    {
        var token = TokenOnRequest();
        var email = FromBase64String(token);

        return _repository.GetUserByEmail(email);
    }

    private string TokenOnRequest()
    {
        var authentication = _httpContextAccessor.HttpContext!.Request.Headers.Authorization.ToString();

        // authentication[7..] "Y3Jpc3RpYW5vQGNyaXN0aWFuby5jb20="
        return authentication["Bearer ".Length..];
    }

    private string FromBase64String(string base64)
    {
        var data = Convert.FromBase64String(base64);

        return System.Text.Encoding.UTF8.GetString(data);
    }
}
