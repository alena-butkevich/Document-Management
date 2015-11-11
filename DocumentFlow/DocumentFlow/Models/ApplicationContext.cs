using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace DocumentFlow.Models
{
   [Table(Name = "Documents")] 
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext() : base("SomeCompany") { }

        public DbSet<Document> documents;

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }

      /*  protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Document>().ToTable("Documents");
        }
       * */
    }
}