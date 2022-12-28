using DAL.Entities;
using DAL.Repositories.Impl;
using DAL.Repositories.Interfaces;
using DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private SoilMonitoringContext db;
        private SoilMonitoringRepository smRepository;
        private AreaRepository areaRepository;
        /**
        public EFUnitOfWork(DbContextOptions options)
        {
            db = new SoilMonitoringContext(options);
        }
        */
        public EFUnitOfWork(SoilMonitoringContext context)
        {
            db = context;
        }
        public ISoilMonitoringRepository SoilMonitorings
        {
            get
            {
                if (smRepository == null)
                    smRepository = new SoilMonitoringRepository(db);
                return smRepository;
            }
        }
        public IAreaRepository Areas
        {
            get
            {
                if (areaRepository == null)
                    areaRepository = new AreaRepository(db);
                return areaRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
