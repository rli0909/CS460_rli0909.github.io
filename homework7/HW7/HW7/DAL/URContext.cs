using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HW7.Models;

namespace HW7.DAL
{
    public class URContext:DbContext
    {
        public URContext() : base("name=GiphyRequest") { }
        public virtual DbSet<GiphyRequest> GiphyRequests { get; set; }
    }
}