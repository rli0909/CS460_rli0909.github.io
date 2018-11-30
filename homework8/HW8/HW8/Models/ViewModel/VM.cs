using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW8.Models.ViewModel
{
    public class VM
    {
        public Bid Bid { get; set; }
        public Item Item { get; set; }
        public IEnumerable<Bid> Bids { get; set; }
        public IEnumerable<Item> Items { get; set; }
    }
}