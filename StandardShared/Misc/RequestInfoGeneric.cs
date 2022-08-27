using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace StandardShared.Misc;

public class RequestInfoGeneric
{
    protected readonly IServiceScope Scope;
    protected readonly HttpContext HttpContext;
    protected Guid? UserUid;
    public string RemoteIp = null!;
    public string? Token;

    public RequestInfoGeneric(IHttpContextAccessor contextAccessor, IServiceScopeFactory scopeFactory)
    {
        Scope = scopeFactory.CreateScope();
        HttpContext = contextAccessor.HttpContext!;

        Init();
    }

    protected virtual void Init()
    {
        UserUid = HttpContext?.Items["userUid"] as Guid?;
        RemoteIp = HttpContext!.Connection.RemoteIpAddress!.ToString();

       if (UserUid == null)
            return;
       
        Token = HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Replace("Bearer ", "");
    }
}

