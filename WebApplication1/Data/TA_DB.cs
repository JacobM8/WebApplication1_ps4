using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
