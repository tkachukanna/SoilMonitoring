using DAL.EF;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories.Impl
{
    public class AreaRepository : BaseRepository<Area>, IAreaRepository
    {
        internal AreaRepository(SoilMonitoringContext context) : base(context)
        {

        }
    }
}
