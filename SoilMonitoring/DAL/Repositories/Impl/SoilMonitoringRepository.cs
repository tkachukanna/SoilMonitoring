using DAL.EF;
using DAL.Entities;
using System;
using DAL.Repositories.Interfaces;
using System.Collections.Generic;
using System.Text;


namespace DAL.Repositories.Impl
{
    public class SoilMonitoringRepository : BaseRepository<SoilMonitoring>, ISoilMonitoringRepository
    {
        internal SoilMonitoringRepository(SoilMonitoringContext context) : base(context)
        {

        }
    }
}
