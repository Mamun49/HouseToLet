using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;


namespace HouseToLet.Models
{
    public partial class ToLetModel : DbContext
    {
        public ToLetModel()
            : base("name=ToLetModel")
        {
        }

        public virtual DbSet<HouseInfo> HouseInfoes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Thana> Thanas { get; set; }
        public virtual DbSet<Image_tbl> Image_tbls { get; set; }
        //public virtual DbSet<PageModel> PageModel { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HouseInfo>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<HouseInfo>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<HouseInfo>()
                .Property(e => e.Size)
                .IsUnicode(false);

            modelBuilder.Entity<HouseInfo>()
                .Property(e => e.DisplayImage)
                .IsUnicode(false);

            //modelBuilder.Entity<HouseInfo>()
            //    .Property(e => e.Images)
            //    .IsUnicode(false);

            modelBuilder.Entity<HouseInfo>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<HouseInfo>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<HouseInfo>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<HouseInfo>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HouseInfo>()
                .Property(e => e.Beds)
                .IsUnicode(false);

            modelBuilder.Entity<HouseInfo>()
                .Property(e => e.Baths)
                .IsUnicode(false);

            modelBuilder.Entity<HouseInfo>()
                .Property(e => e.Rent)
                .IsUnicode(false);

            modelBuilder.Entity<HouseInfo>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<HouseInfo>()
                .Property(e => e.Garage)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.ConfirmPassword)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Membership)
                .IsUnicode(false);
            modelBuilder.Entity<City>()
                .Property(e => e.CName)
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.SName)
                .IsUnicode(false);

            modelBuilder.Entity<Thana>()
                .Property(e => e.ThanaName)
                .IsUnicode(false);
            
            modelBuilder.Entity<Image_tbl>()
                .Property(e => e.Images)
                .IsUnicode(false);
            
            

        }
    }
}
