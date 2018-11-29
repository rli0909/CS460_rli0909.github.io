using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HW7.Models
{
    public class GiphyRequest
    {
        [Key]
        public int ID { get; set; }
        public string Word { get; set; }
        public string IP { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}