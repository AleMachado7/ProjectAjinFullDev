using RestSharp;
using System.Text.Json;
using Xpto.Core.Shared.Entities;

namespace Xpto.Core.Shared.Functions
{
    public static class ZipCodeLookup
    {
        private static RestClient client = new RestClient("https://viacep.com.br/");

        public static async Task<Address> GetAddressByZipCodeAsync(string zipCode)
        {
            var address = new Address();
            var request = new RestRequest($"ws/{zipCode}/json", Method.Get);
            var response = await client.ExecuteAsync(request);            
            if (response.IsSuccessful)
            {                
                address = JsonSerializer.Deserialize<Address>(response.Content);
                return address;
            }
            return address;
        }
    }
}
