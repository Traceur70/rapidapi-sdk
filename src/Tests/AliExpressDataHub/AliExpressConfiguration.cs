using T70.RapidApi;

namespace T70.Tests.AliExpressDataHub;

public class AliExpressConfiguration(ApiSubscription[] apiSubscriptions): ApiConfiguration(
    name: nameof(AliExpressDataHubClient),
    headerLimitRemaining: "x-ratelimit-default-remaining",
    headerLimitReset: "x-ratelimit-default-reset",
    subscriptions: apiSubscriptions);
