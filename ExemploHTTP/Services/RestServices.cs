using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

using System.Text.Json;
using System.Linq.Expressions;
using System.Diagnostics;
using ExemploHTTP.Models;


namespace ExemploHTTP.Services
{
    public class RestServices
    {
        HttpClient client;
        private Foto foto; 

        private List<Foto> fotos;
        
        private JsonSerializerOptions _serializerOptions;

        RestServices()
        { 
            client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions{
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

        }

        public async Task<List<Foto>> getPhotosAsync() 
        {
            Uri uri = new Uri("https://jsonplaceholder.typicode.com/photos");
            try {
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();


                    fotos = JsonSerializer.Deserialize<List<Foto>>(content, _serializerOptions);
                } 
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return fotos;

        }
    }
}
