using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    public class Todo
    {
        public Guid TodoId {get; set;} = Guid.NewGuid();
        public string Title {get; set;}
        public string Description {get; set;}
    }
}