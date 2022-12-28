using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EF
{
    public class SoilMonitoringContext : DbContext
    {
        public DbSet<SoilMonitoring> SoilMonitorings { get; set; }
        public DbSet<Area> Areas { get; set; }

        public SoilMonitoringContext(DbContextOptions options) : base(options)
        {

        }
    }
}
