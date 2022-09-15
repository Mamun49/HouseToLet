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

    [Table("HouseInfo")]
    public partial class HouseInfo
    {
        [Key]
        public int HomeId { get; set; }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string UserId { get; set; }

        //[Required]
        [StringLength(50)]
        [DisplayName("Select Category")]
        public string Category { get; set; }

        //[Required]
        [StringLength(50)]
        [DisplayName("Size of the House")]
        public string Size { get; set; }

        
        [DataType(DataType.Upload)]
        [DisplayName("Insert a Display Image")]
        public string DisplayImage { get; set; }

       

        [Required]
        [StringLength(50)]
        public string State { get; set; }

        
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(500)]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Required]
        [StringLength(500)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [DisplayName("Select Number of Beds")]
        public string Beds { get; set; }
        [DisplayName("Select Number of Baths")]
        public string Baths { get; set; }
        public string Status { get; set; }
        public string Garage { get; set; }
        public string Rent { get; set; }
        //public string SName { get; set; }
        //public string CName { get; set; }
        //public string ThanaName { get; set; }
        //public int SId { set; get; }
        //public int CId { set; get; }
        //public int ThanaId { set; get; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}
