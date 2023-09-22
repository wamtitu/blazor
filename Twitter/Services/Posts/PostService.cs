using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Twitter.Models;

namespace Twitter.Services.Posts
{
    public class PostService : IPostInterface
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseUrl = "https://jsonplaceholder.typicode.com/posts";

        public PostService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Post>> GetPostAsync()
        {
            var res = await _httpClient.GetAsync(BaseUrl);
            var response = await res.Content.ReadAsStringAsync();

            var results = JsonConvert.DeserializeObject<List<Post>>(response);
            if(results != null){
                return results;
            }
            return new List<Post>();
        }
    }
}