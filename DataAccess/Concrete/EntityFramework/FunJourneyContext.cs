using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Context Class'ı:Db tabloları ile proje class'larını bağladığımız yerdir.
    public class FunJourneyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-MT6A41P;Initial Catalog=Dbo_FunJourney;Integrated Security=True");
        }

        public DbSet<Place> Tbl_Places { get; set; }
        public DbSet<Province> Tbl_Provinces { get; set; }
        public DbSet<Category> Tbl_Categories { get; set; }
        public DbSet<PlaceImage> Tbl_PlaceImages { get; set; }


    }
}
