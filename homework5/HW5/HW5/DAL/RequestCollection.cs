using HW5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW5.DAL
{
    public class RequestCollection
    {
        public List<Request> Requests;

        public RequestCollection()
        {
            Requests = new List<Request>
            {
                new Request{ FirstName = "Lucy", LastName = "Lee", PhoneNum = "503-851-1885", AptName = "Kingston", Unit = 4, Expl = "Repair shower head"},
                new Request{ FirstName = "Jessy", LastName = "Chen", PhoneNum = "503-851-1885", AptName = "White", Unit = 3, Expl = "Door repair"},
                new Request { FirstName = "Lucy", LastName = "Lee", PhoneNum = "503-851-1885", AptName = "Kingston", Unit = 4, Expl = "Repair shower head" },
                new Request { FirstName = "Lucy", LastName = "Lee", PhoneNum = "503-851-1885", AptName = "Kingston", Unit = 4, Expl = "Repair shower head" },
                new Request { FirstName = "Lucy", LastName = "Lee", PhoneNum = "503-851-1885", AptName = "Kingston", Unit = 4, Expl = "Repair shower head" },
                new Request { FirstName = "Lucy", LastName = "Lee", PhoneNum = "503-851-1885", AptName = "Kingston", Unit = 4, Expl = "Repair shower head" },
            };
        }
    }
}