using System;
using H2O.DataAccess.Core.Context;
using H2O.DataAccess.Core.Repositories;
using H2O.DataAccess.Core.Test._TestObjects;
using H2O.DataAccess.Core.Uow;
using Microsoft.Extensions.Logging;
using Xunit;

namespace H2O.DataAccess.Core.Test.Uow
{
    public class UowProviderTests
    {
        [Fact]
        public void TestGetCustomRepository()
        {

            var logger = new Moq.Mock<ILogger<DataAccess>>();
            var sp = new Moq.Mock<IServiceProvider>();

            var myContext = new InMemoryContext(new Microsoft.EntityFrameworkCore.DbContextOptions<InMemoryContext>());

            sp.Setup((o) => o.GetService(typeof(IEntityContext))).Returns(myContext);
            sp.Setup((o) => o.GetService(typeof(IFooRepository))).Returns(new FooRepository(logger.Object, myContext));

            var provider = new UowProvider(logger.Object, sp.Object);

            var uow = provider.CreateUnitOfWork();

            uow.GetCustomRepository<IFooRepository>();
        }
        [Fact]
        public void TestGetGenericRepository()
        {

            var logger = new Moq.Mock<ILogger<DataAccess>>();
            var sp = new Moq.Mock<IServiceProvider>();

            var myContext = new InMemoryContext(new Microsoft.EntityFrameworkCore.DbContextOptions<InMemoryContext>());

            sp.Setup((o) => o.GetService(typeof(IEntityContext))).Returns(myContext);
            sp.Setup((o) => o.GetService(typeof(IRepository<Foo>))).Returns(new GenericEntityRepository<Foo>(logger.Object));

            var provider = new UowProvider(logger.Object, sp.Object);

            var uow = provider.CreateUnitOfWork();

            uow.GetRepository<Foo>();
        }
    }
}