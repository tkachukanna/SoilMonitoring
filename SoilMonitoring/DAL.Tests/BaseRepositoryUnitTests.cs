using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using Microsoft.EntityFrameworkCore;
using DAL.EF;
using DAL.Entities;

namespace DAL.Tests
{
    public class BaseRepositoryUnitTests
    {
        [Fact]
        public void Create_InputAreaInstance_CalledAddMethodOfDBSetWithAreaInstance()
        {
            DbContextOptions opt = new 
                DbContextOptionsBuilder<SoilMonitoringContext>().Options;
            var mockContext = new Mock<SoilMonitoringContext>(opt);
            var mockDbSet = new Mock<DbSet<Area>>();
            mockContext
                .Setup(context =>
                    context.Set<Area>(
                        ))
                .Returns(mockDbSet.Object);
            var repository = new TestAreaRepository(mockContext.Object);
            Area expectedArea = new Mock<Area>().Object;
            repository.Create(expectedArea);
            mockDbSet.Verify(
                dbSet => dbSet.Add(expectedArea), Times.Once());
        }

        [Fact]
        public void Delete_InputId_CalledFindAndRemoveMethodsOfDBSetWithCorrectArg()
        {
            DbContextOptions opt = new DbContextOptionsBuilder<SoilMonitoringContext>()
                .Options;
            var mockContext = new Mock<SoilMonitoringContext>(opt);
            var mockDbSet = new Mock<DbSet<Area>>();
            mockContext
                .Setup(context =>
                    context.Set<Area>(
                        ))
                .Returns(mockDbSet.Object);
            var repository = new TestAreaRepository(mockContext.Object);
            Area expectedArea = new Area() { IdArea = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedArea.IdArea)).Returns(expectedArea);
            repository.Delete(expectedArea.IdArea);
            mockDbSet.Verify(
                dbSet => dbSet.Find(
                    expectedArea.IdArea
                    ), Times.Once());
            mockDbSet.Verify(
                dbSet => dbSet.Remove(
                    expectedArea
                    ), Times.Once());
        }

        [Fact]
        public void Get_InputId_CalledFindMethodOfDBSetWithCorrectId()
        {
            DbContextOptions opt = new DbContextOptionsBuilder<SoilMonitoringContext>()
                .Options;
            var mockContext = new Mock<SoilMonitoringContext>(opt);
            var mockDbSet = new Mock<DbSet<Area>>();
            mockContext
                .Setup(context =>
                    context.Set<Area>(
                        ))
                .Returns(mockDbSet.Object);

            Area expectedArea = new Area() { IdArea = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedArea.IdArea))
                    .Returns(expectedArea);
            var repository = new TestAreaRepository(mockContext.Object);
            var actualArea = repository.Get(expectedArea.IdArea);
            mockDbSet.Verify(
                dbSet => dbSet.Find(expectedArea.IdArea), Times.Once());
            Assert.Equal(expectedArea, actualArea);
        }
    }
}
