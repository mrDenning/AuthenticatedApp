using AuthenticatedApp.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace AuthenticatedApp.Client
{
    public class APIClient
    {
        private readonly HttpClient client;
        public APIClient(IHttpClientFactory httpClient)
        {
            client = httpClient.CreateClient("ApiClient");
        }

        public async Task<IEnumerable<DataModel>> GetData()
        {
            IEnumerable<DataModel> dataModels = await client.GetFromJsonAsync<IEnumerable<DataModel>>("Data");

            if (dataModels is not null)
            {
                return dataModels;
            }
            else
            {
                Console.WriteLine("Something went wrong");
                return null;
            }
        }

    }
}
