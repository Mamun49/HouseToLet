using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HouseToLet.Models
{
    public class PageModel
    {
        public PageModel()
        {
            this.houseinfo = new HouseInfo();
            this.city = new City();
            this.state = new State();
            this.thana = new Thana();
            this.user = new User();
            this.cascd = new cascade();
            this.imgtbl = new Image_tbl();


        }

       [Key]
        public HouseInfo houseinfo { get; set; }
        public City city { get; set; }
        public State state { get; set; }
        public Thana thana { get; set; }
        public User user { get; set; }
        public cascade cascd { get; set; }
        public Image_tbl imgtbl { get; set; }
        
        


    }
}