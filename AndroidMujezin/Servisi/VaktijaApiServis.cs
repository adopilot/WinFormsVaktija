using AndroidMujezin.Modeli;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

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
            var apiUrl = "https://api.vaktija.ba";
            _client.BaseAddress = new Uri(apiUrl);
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            _client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }
        public async Task<List<string>> Mjesta()
        {
            var list = new List<string>();
            
                HttpResponseMessage response = await _client.GetAsync("vaktija/v1/lokacije");
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    list = JsonSerializer.Deserialize<List<string>>(content, _serializerOptions);
                }
                
            
            return list;

        }
        public async Task<VaktijaZaMjesec> PovuciVaktijuZaMjesec(int lokcaijId, int godina , int mjesec,CancellationToken cancellationToken)
        {


            VaktijaZaMjesec model = null;

            HttpResponseMessage response = await _client.GetAsync($"/vaktija/v1/{lokcaijId}/{godina}/{mjesec}", cancellationToken);
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode )
            {
                var json = await response.Content.ReadAsStringAsync();
                model = JsonSerializer.Deserialize<VaktijaZaMjesec>(json);
            }
            return model;
        }
    }
}
