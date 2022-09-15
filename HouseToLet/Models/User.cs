namespace HouseToLet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Unique Id")]
        public string UserId { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Full Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Mail { get; set; }
        //[MaxLength(11), MinLength(11)]
        //[Range(11, 11, ErrorMessage = "Number Must be a 11 digit without country code!")]
        [DisplayName("Mobile Number")]
        public int PhoneNum { get; set; }

        [Required]
        //[StringLength(50)]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }

        [Required]
        //[StringLength(50)]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }

        [StringLength(50)]
        public string Membership { get; set; }
    }
}
