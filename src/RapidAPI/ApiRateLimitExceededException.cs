namespace T70.RapidApi;

public class ApiRateLimitExceededException : HttpRequestException
{
    public ApiRateLimitExceededException()
    {
    }

    public ApiRateLimitExceededException(string message)
        : base(message)
    {
    }

    public ApiRateLimitExceededException(string message, Exception inner)
        : base(message, inner)
    {
    }
}