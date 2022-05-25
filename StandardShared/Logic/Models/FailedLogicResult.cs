namespace StandardShared.Logic.Models;

using System.Net;

public class FailedLogicResult : GenericLogicResult
{
    public override bool Status => false;
    public override HttpStatusCode HttpCode { get; init; } = HttpStatusCode.BadRequest;
}