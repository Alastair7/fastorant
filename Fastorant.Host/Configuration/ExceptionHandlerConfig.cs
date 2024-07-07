using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;

namespace Fastorant.Host.Configuration;

public class ExceptionHandlerConfig : IExceptionHandler
{
    private const string UnhandledExceptionMsg = "An unexpected exception has occured";

    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var problemDetails = CreateProblemDetails(httpContext, exception);

        const string contentType = "application/problem+json";
        httpContext.Response.ContentType = contentType;

        await httpContext.Response.WriteAsJsonAsync(problemDetails, cancellationToken);

        return true;
    }

    private static ProblemDetails CreateProblemDetails(in HttpContext context, in Exception exception)
    {
        var statusCode = context.Response.StatusCode;
        var reasonPhrase = ReasonPhrases.GetReasonPhrase(statusCode);
        if (string.IsNullOrEmpty(reasonPhrase))
        {
            reasonPhrase = UnhandledExceptionMsg;
        }

        var problemDetails = new ProblemDetails
        {
            Status = statusCode,
            Title = reasonPhrase,
            Detail = $"[{exception.GetType()}] {exception.Message}",
        };

        return problemDetails;
    }
}


