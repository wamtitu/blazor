using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Twitter.Models;

namespace Twitter.Services.USers
{
    public class USerService : IUserInterface
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseUrl = "https://jsonplaceholder.typicode.com/users";

        public USerService(HttpClient httpClient)
        {
            _httpClient = httpClient; 
        }
        public async Task<List<User>> GetUsersAsync()
        {
            var res = await _httpClient.GetAsync(BaseUrl);
            var response = await res.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<User>>(response.ToString());
            if(results != null){
                return results;
            }
            return new List<User>();
        }
    }
}