namespace HouseToLet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;
    using System.Data;
    using System.Data.SqlClient;
    using System.Configuration;
    using Microsoft.AspNetCore.Http;

    [Table("Image_tbl")]
    public partial class Image_tbl
    {
        [Key]
        public int ImgId { get; set; }

        public string Images { get; set; }

       
        public int HomeId { get; set; }

        
    }
}
