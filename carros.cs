using MassTransit.Clients;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamento_2
{

    public class carros
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string placa { get; set; }
        public string cor { get; set; }

        public async Task<List<carros>> ObtercarrosAsync()
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:44337/api/estacionamento", Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<List<carros>>
                    (response.Content);
            else
                return null;

        }
    }
        
}
