namespace HW7.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserInput")]
    public partial class UserInput
    {
        public int ID { get; set; }

        [StringLength(64)]
        public string Word { get; set; }

        [Required]
        [StringLength(128)]
        public string IP { get; set; }

        public DateTime Date { get; set; }
    }
}
