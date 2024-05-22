using Gyakorlas_Cars_Owners.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas_GUI_car_dealers
{
    public class DataContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Owner> Owners { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=car_dealers;Uid=root;Pwd=;", ServerVersion.AutoDetect("Server=localhost;Database=car_dealers;Uid=root;Pwd=;"));
        }
    }
}
