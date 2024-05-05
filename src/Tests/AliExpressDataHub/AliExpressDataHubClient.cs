using RapidApiSdk.AliExpressDataHub.Models;
using System.Text.Json;
using T70.RapidApi;

namespace T70.Tests.AliExpressDataHub;

public class AliExpressDataHubClient(
    HttpClient client,
    AliExpressConfiguration apiKeyRotation)
    : RapidApiClient(client, apiKeyRotation)
{
    public Task<SearchResult> GetItemDetail(string locale, string currency, string region, string itemId, CancellationToken cancellationToken) =>
        Get($"item_detail?locale={locale}&currency={currency}&region={region}&itemId={itemId}", SearchItemDetailResultJsonContext.Default.SearchResult, cancellationToken)!;

    public static SearchResult GetItemDetailSample() =>
        JsonSerializer.Deserialize(SearchResult.Json, SearchItemDetailResultJsonContext.Default.SearchResult)!;

}

