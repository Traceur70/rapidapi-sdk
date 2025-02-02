using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace T70.RapidApi;

public abstract class RapidApiClient(HttpClient client, ApiConfiguration apiConfiguration)
{
    protected Task<TResult?> Post<TContent, TResult>(
        string path,
        TContent content,
        JsonTypeInfo<TContent> contentJsonTypeInfo,
        JsonTypeInfo<TResult> resultJsonTypeInfo,
        CancellationToken cancellationToken) =>
        SendAsync(
            httpMethod: HttpMethod.Post,
            path: path,
            content: JsonContent.Create(content, contentJsonTypeInfo),
            resultJsonTypeInfo: resultJsonTypeInfo,
            cancellationToken: cancellationToken);

    protected Task<HttpResponseMessage> Post<TContent>(
        string path,
        TContent content,
        JsonTypeInfo<TContent> contentJsonTypeInfo,
        CancellationToken cancellationToken) =>
        SendAsync(
            httpMethod: HttpMethod.Post,
            path: path,
            content: JsonContent.Create(content, contentJsonTypeInfo),
            cancellationToken: cancellationToken);

    protected Task<HttpResponseMessage> Get(string path, CancellationToken cancellationToken) =>
        SendAsync(
            httpMethod: HttpMethod.Get,
            path: path,
            cancellationToken: cancellationToken);

    protected Task<TResult?> Get<TResult>(string path, JsonTypeInfo<TResult> resultJsonTypeInfo, CancellationToken cancellationToken) =>
        SendAsync(
            httpMethod: HttpMethod.Get,
            path: path,
            content: null,
            resultJsonTypeInfo: resultJsonTypeInfo,
            cancellationToken: cancellationToken);

    private Task<TResult?> SendAsync<TResult>(
        HttpMethod httpMethod,
        string path,
        JsonContent? content,
        JsonTypeInfo<TResult> resultJsonTypeInfo,
        CancellationToken cancellationToken = default) =>
        SendAsync(httpMethod, path, content, cancellationToken)
            .ContinueWith(t => t.Result.Content.ReadAsStringAsync())
            .ContinueWith(t => JsonSerializer.Deserialize(t.Result.Result, resultJsonTypeInfo));

    private async Task<HttpResponseMessage> SendAsync(
        HttpMethod httpMethod,
        string path,
        JsonContent? content = null,
        CancellationToken cancellationToken = default)
    {
        var date = DateTime.UtcNow;
        if (apiConfiguration.SetRotation(date, out var newSubscription))
        {
            client.BaseAddress = new Uri($"https://{newSubscription.Host}");
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", newSubscription.ApiKey);
            client.DefaultRequestHeaders.Add("X-RapidAPI-Host", newSubscription.Host);
        }

        var response = await client.SendAsync(
            request: new(httpMethod, path) { Content = content },
            completionOption: HttpCompletionOption.ResponseContentRead,
            cancellationToken: cancellationToken);

        apiConfiguration.SetAvailability(date, response.Headers);
        return response;
    }
}
