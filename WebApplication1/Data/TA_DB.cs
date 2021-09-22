using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class TA_DB : DbContext
    {
        public TA_DB(DbContextOptions<TA_DB> options) : base(options)
        {
        }

        public DbSet<Application> Applications { get; set; }
    }
}
