using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DevopsTest.Models
{
    public class DevopsTestContext : DbContext
    {
        public DevopsTestContext (DbContextOptions<DevopsTestContext> options)
            : base(options)
        {
        }

        public DbSet<DevopsTest.Models.Certification> Certification { get; set; }
    }
}
