using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book
    {
        
        public Guid BookId {get; set;}
        public string Title{get; set;}
        public string description{get; set;}
        public List<string>? Authors {get; set;}

         public Book()
        {
        Authors = new List<string>();
            }
    }
}