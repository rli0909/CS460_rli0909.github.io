namespace HW8.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bid
    {
        [Key]
        public int BidID { get; set; }
        
        public int ItemID { get; set; }

        [Required]
        [StringLength(64)]
        public string BuyerName { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] Timestamp { get; set; }

        public virtual Item Item { get; set; }

        public virtual Buyer Buyer { get; set; }
    }
}
