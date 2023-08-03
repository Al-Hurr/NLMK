using NLMK.Client.Models;

namespace NLMK.Client.Services
{
    public class HttpClientService
    {
        private readonly HttpClient _httpClient;
        private readonly string _url;

        public HttpClientService(WebServiceOptions webServiceOptions)
        {
            _url = $"http://{webServiceOptions.IpAddress}:{webServiceOptions.Port}";
            _httpClient = new HttpClient();
        }

        public async Task<string> SendCalculateAsync(int divident, int divider)
        {
            var response = await _httpClient.GetAsync($"{_url}/calculator?divident={divident}&divider={divider}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
