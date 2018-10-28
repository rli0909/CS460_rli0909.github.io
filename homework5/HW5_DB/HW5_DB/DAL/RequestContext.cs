using HW5_DB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HW5_DB.DAL
{
    public class RequestContext : DbContext
    {
        public RequestContext() : base("name=UserRequests")
        {

        }

        //The way entity framework represent a table
        public virtual DbSet<Request> Requests { get; set; }
    }
}