using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_W04_ModelFirst.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public List<Books> BooksName { get; set; } 
        
    }
}