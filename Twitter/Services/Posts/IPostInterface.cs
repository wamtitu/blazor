using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twitter.Models;

namespace Twitter.Services.Posts
{
    public interface IPostInterface
    {
        Task<List<Post>> GetPostAsync();
    }
}