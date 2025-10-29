using System.Net.Http.Json;
using CRMAppV2.Models.CRMApp;

namespace CRMAppV2.CRMApp
{
    public class CRMAppService: ICRMAppService
    {
        private readonly HttpClient _http;

        public CRMAppService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<MeetingsTasksType>> GetMeetingsTasksList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/2fd4ecd6-da6c-4e37-e666-08dab79fa5b4", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<MeetingsTasksType>>().ConfigureAwait(false);
            }

            return new List<MeetingsTasksType>();
        }
    }
}
