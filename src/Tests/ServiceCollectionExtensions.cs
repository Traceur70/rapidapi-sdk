using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using T70.RapidApi;
using T70.Tests.AliExpressDataHub;

namespace T70.Tests;

public static class ServiceCollectionExtensions
{
    public static IHttpClientBuilder AddAliExpressDataHub(this IServiceCollection services, IConfiguration configuration) =>
        services.AddRapidApiClient<AliExpressConfiguration, AliExpressDataHubClient>(new AliExpressConfiguration(
            configuration.AsEnumerable()
                .OrderBy(pair => pair.Key)
                .Where(pair => pair.Key.StartsWith("RAPIDAPI_ALIEXPRESSDATAHUB"))
                .Select(pair => pair.Value!.Split('|'))
                .Select(values => new ApiSubscription(values[0], values[1], values[2], true))
                .ToArray()));

    public static IHttpClientBuilder AddRapidApiClient<TApiConfiguration, TRapidApiClient>(this IServiceCollection services, TApiConfiguration apiConfiguration)
        where TApiConfiguration : ApiConfiguration
        where TRapidApiClient : RapidApiClient => services
            .AddSingleton(apiConfiguration)
            //TODO check nameof(TRapidApiClient) === nameof(AliExpressDataHubClient)
            .AddHttpClient<TRapidApiClient>(nameof(TRapidApiClient));
}
