
using HotelManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DBContext
{
    public class HositalManagementDbContext: DbContext
    {
        public HositalManagementDbContext(DbContextOptions<HositalManagementDbContext> options) : base(options)
        {


        }

        public DbSet<Orders> Orders { get; set; }
    }
}
