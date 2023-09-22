using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twitter.Models;

namespace Twitter.Services.USers
{
    public interface IUserInterface
    {
        public Task<List<User>> GetUsersAsync();
    }
}