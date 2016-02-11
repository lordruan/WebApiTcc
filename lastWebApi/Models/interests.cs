namespace lastWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class interests
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal id { get; set; }

        [Required]
        [StringLength(15)]
        public string description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal users_id { get; set; }

        public bool active { get; set; }
        
    }
}
