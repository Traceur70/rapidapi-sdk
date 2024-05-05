namespace T70.RapidApi;

public class ApiSubscription(string name, string host, string apiKey, bool hardLimit)
{
    public int? LastLimitRemaining { get; set; }

    public DateTime? LastLimitReset { get; set; }

    public string Name { get; } = name;

    public bool HardLimit { get; } = hardLimit;

    public string Host { get; } = host;

    public string ApiKey { get; } = apiKey;
}
