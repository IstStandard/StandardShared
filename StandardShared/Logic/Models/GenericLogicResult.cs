using System.Net;

namespace StandardShared.Logic.Models;

public class GenericLogicResult
{
    public virtual bool Status { get; init; }
    public virtual string Message { get; init; } = String.Empty;
    public virtual HttpStatusCode HttpCode { get; init; } = HttpStatusCode.OK;
}