using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ISoilMonitoringRepository SoilMonitorings { get; }
        IAreaRepository Areas { get; }
        void Save();
    }
}
