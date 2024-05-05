using System.Net.Http.Headers;

namespace T70.RapidApi;

public abstract class ApiConfiguration(
    string name,
    string headerLimitRemaining,
    string headerLimitReset,
    ApiSubscription[] subscriptions)
{
    public string Name { get; } = name;

    private ApiSubscription? currentSubscription;

    public bool SetRotation(DateTime fromDate, out ApiSubscription newSubscription)
    {
        var needRotation = currentSubscription is null || currentSubscription.LastLimitRemaining < 2;
        if (needRotation)
        {
            currentSubscription = subscriptions.FirstOrDefault(s => !s.LastLimitReset.HasValue
                || !s.LastLimitReset.HasValue
                || s.LastLimitRemaining > 2
                || s.LastLimitReset < fromDate)
                    ?? subscriptions.FirstOrDefault(s => !s.HardLimit)
                    ?? throw new ApiRateLimitExceededException($"No more available subscriptions for {Name}");
        }
        newSubscription = currentSubscription!;
        return needRotation;
    }

    public void SetAvailability(DateTime fromDate, HttpResponseHeaders headers)
    {
        currentSubscription!.LastLimitRemaining = headers.TryGetValues(headerLimitRemaining, out var limitRemaining)
            ? int.Parse(limitRemaining.First())
            : 0;

        currentSubscription!.LastLimitReset = headers.TryGetValues(headerLimitReset, out var limitResets)
            ? fromDate.AddSeconds(int.Parse(limitResets.First()))
            : fromDate;
    }
}
