using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HW5.Models
{
    public class Request
    {
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [StringLength(10)]
        public string LastName { get; set; }

        [Required]
        [StringLength(15)]
        public string PhoneNum { get; set; }

        [Required]
        public string AptName{ get; set; }

        [Required]
        public int unit { get; set; }


    }
}