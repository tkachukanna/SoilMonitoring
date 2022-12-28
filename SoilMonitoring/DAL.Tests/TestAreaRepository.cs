using DAL.Entities;
using DAL.Repositories.Impl;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Tests
{
    class TestAreaRepository : BaseRepository<Area>
    {
        public TestAreaRepository(DbContext context) : base(context)
        {

        }
    }
}
