using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Twitter.Models;

namespace Twitter.Services.Comments
{
    public class CommentService : ICommentInterface
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseUrl = "https://jsonplaceholder.typicode.com/comments";

        public CommentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Comment>> GetCommentsAsync()
        {
            var res = await _httpClient.GetAsync(BaseUrl);
            var response = await res.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<Comment>>(response.ToString());
            if(results != null){
                return results;
            }
            return new List<Comment>();
        }

        public async Task<List<Comment>> GetCommentsByPostAsync(int id)
        {
            var res = await _httpClient.GetAsync($"{BaseUrl}/comments?postId={id}");
            var response = await res.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<Comment>>(response.ToString());
            if(results != null){
                return results;
            }
            return new List<Comment>();
        }
    }
}