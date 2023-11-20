using System.Threading.Tasks;
using PeekalinkSdk.DataContracts;
using RestSharp;
using RestSharp.Authenticators;

namespace Restub.Tests.Github
{
    /// <summary>
    /// Peekalink.io client.
    /// </summary>
    public class PeekalinkClient : RestubClient, IAuthenticator
    {
        public PeekalinkClient(string apiKey) : base("https://api.peekalink.io/")
        {
            ApiKey = apiKey;
        }

        private string ApiKey { get; }

        public void Authenticate(IRestClient client, IRestRequest request) =>
            request.AddHeader("X-API-Key", ApiKey);

        public LinkPreview Preview(string link) =>
            PreviewAsync(link).ConfigureAwait(false).GetAwaiter().GetResult();

        public bool IsAvailable(string link) =>
            IsAvailableAsync(link).ConfigureAwait(false).GetAwaiter().GetResult();

        public Task<LinkPreview> PreviewAsync(string link) =>
            PostAsync<LinkPreview>(string.Empty, new
            {
                link,
            });

        public async Task<bool> IsAvailableAsync(string link) =>
            (await PostAsync<Available>("/is-available/", new
            {
                link,
            }))
            .IsAvailable;
    }
}
