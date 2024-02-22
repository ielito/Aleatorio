using System;
using System.Net.Http;

namespace Aleatorio
{
    public class MyLibrary : IMyLibrary
    {
        public string FetchData()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync("https://superbandi.x10.mx/home.php").Result; // Chamada síncrona
                response.EnsureSuccessStatusCode();
                string responseBody = response.Content.ReadAsStringAsync().Result; // Chamada síncrona
                return responseBody;
            }
        }
    }
}
