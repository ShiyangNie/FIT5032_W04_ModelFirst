using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_W04_ModelFirst.Models
{
    public class Books
    {
        public int Id { get; set; }
        public String BookName { get; set; }
        public String BookDetail { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}