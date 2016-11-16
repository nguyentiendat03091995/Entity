using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Entity1.Models;

namespace Entity1.Models
{
    public class BookContent : DbContext
    {
        public BookContent()
            : base("name=BookContent")
        {

        }
        public DbSet<SACH> SACHs { get; set; }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    // khai báo Id sẽ là khóa chính
        //    modelBuilder.Entity<SACH>().HasKey(b => b.Id);

        //    // khai báo Id sẽ tự động tăng
        //    modelBuilder.Entity<SACH>().Property(b => b.Id)
        //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}