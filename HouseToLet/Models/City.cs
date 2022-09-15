namespace HouseToLet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("City")]
    public partial class City
    {
        [Key]
        public int CId { get; set; }

        [StringLength(50)]
        public string CName { get; set; }

        public int? SId { get; set; }
    }
}
