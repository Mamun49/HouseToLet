namespace HouseToLet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Thana")]
    public partial class Thana
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ThanaId { get; set; }

        [StringLength(50)]
        public string ThanaName { get; set; }

        public int? CId { get; set; }
    }
}
