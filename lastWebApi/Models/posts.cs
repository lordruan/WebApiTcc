namespace lastWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class posts
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal id { get; set; }

        [Required]
        [StringLength(120)]
        public string description { get; set; }

        public bool active { get; set; }

        [Column(TypeName = "numeric")]
        public decimal users_id { get; set; }

        [Required]
        public string image { get; set; }
        
    }
}
