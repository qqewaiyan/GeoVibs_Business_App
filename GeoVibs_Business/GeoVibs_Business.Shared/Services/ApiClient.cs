using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;

namespace GeoVibs_Business.Shared.Services
{
    public class ApiClient
    {
        private readonly HttpClient _http;

        public ApiClient(HttpClient http)
        {
            _http = http;
        }

        public Task<T?> GetAsync<T>(string url)
            => _http.GetFromJsonAsync<T>(url);

        public async Task<T?> PostAsync<T>(string url, object body)
        {
            var res = await _http.PostAsJsonAsync(url, body);
            res.EnsureSuccessStatusCode();
            return await res.Content.ReadFromJsonAsync<T>();
        }

        public async Task PostAsync(string url, object body)
        {
            var res = await _http.PostAsJsonAsync(url, body);
            res.EnsureSuccessStatusCode();
        }

        public async Task DeleteAsync(string url)
        {
            var res = await _http.DeleteAsync(url);
            res.EnsureSuccessStatusCode();
        }

    }

}
