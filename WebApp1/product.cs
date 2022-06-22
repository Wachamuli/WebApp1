namespace WebApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("product")]
    public partial class product
    {
        public int id { get; set; }

        [StringLength(50)]
        public string code { get; set; }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        public decimal listPrice { get; set; }

        public decimal purchasePrice { get; set; }

        public int minxStock { get; set; }

        public int maxStock { get; set; }

        public decimal? width { get; set; }

        public decimal? height { get; set; }

        public decimal? weight { get; set; }

        [StringLength(20)]
        public string color { get; set; }

        [StringLength(260)]
        public string picture { get; set; }

        public bool enabled { get; set; }

        public DateTime createdDate { get; set; }

        public int? supplierId { get; set; }

        public int? categoryId { get; set; }

        public int? markId { get; set; }

        public virtual category category { get; set; }

        public virtual mark mark { get; set; }

        public virtual supplier supplier { get; set; }
    }
}
