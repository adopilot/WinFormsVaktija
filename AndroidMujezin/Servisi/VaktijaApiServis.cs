using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AndroidMujezin.Servisi
{
    public class VaktijaApiServis
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;
        private ConfigServis _configServis;

        public VaktijaApiServis(ConfigServis configServis)
        {
            _configServis = configServis;   
            _client = new HttpClient();
            var apiUrl = _configServis.getModel().ApiUrl;
            if (string.IsNullOrEmpty(apiUrl) )
            {
                apiUrl = "https://api.vaktija.ba";
            }
            _client.BaseAddress = new Uri(apiUrl);
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }
        public async Task<List<string>> Mjesta()
        {
            var list = new List<string>();
            try
            {
                HttpResponseMessage response = await _client.GetAsync("vaktija/v1/lokacije");
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    list = JsonSerializer.Deserialize<List<string>>(content, _serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
            await Task.Delay(1);
            return list;

        }
    }
}
