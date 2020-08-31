using FIT5032_W04_ModelFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace FIT5032_W04_ModelFirst.Context
{
    public class PublishersBookks: DbContext
    {
        public DbSet<Models.Publisher> Publishers { get; set; }
        public DbSet<Books> Bookss { get; set; }
    }

    
}