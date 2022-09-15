namespace HouseToLet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("State")]
    public partial class State
    {
        [Key]
        public int SId { get; set; }

        [StringLength(50)]
        public string SName { get; set; }
    }
}
