namespace HW5_DB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Request
    {
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
        public string AptName { get; set; }

        public int Unit { get; set; }

        [Required]
        [StringLength(30)]
        public string Expl { get; set; }
    }
}
