using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HW5_DB.Models
{
    public class Request
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [StringLength(10)]
        public string LastName { get; set; }

        [Required]
        [StringLength(15)]
        public string PhoneNum { get; set; }

        [Required]
        [StringLength(30)]
        public string AptName{ get; set; }

        [Required]
        public int Unit { get; set; }

        [Required]
        [StringLength(30)]
        public string Expl { get; set; }


        public override string ToString()
        {
            return $"{base.ToString()}: {FirstName} {LastName} Phone={PhoneNum} Apt={AptName} Unit={Unit} Explaination={Expl}";
        }

    }
}