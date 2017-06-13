﻿using System.Linq;
using H2O.DataAccess.Core.Paging;
using H2O.DataAccess.Core.Repositories;
using H2O.DataAccess.Core.Startup;
using H2O.DataAccess.Core.Test._TestObjects;
using H2O.DataAccess.Core.Uow;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace H2O.DataAccess.Core.Test.Startup.ServiceCollectionExtensionsTests
{
    public class AddDataAccessOptionsTests
    {
        [Fact]
        private void UowProviderIsRegisteredAsSingleton()
        {
            var services = new ServiceCollection();

            services.AddDataAccess<TestContext>();

            var registrations = services.Where(sd => sd.ServiceType == typeof(IUowProvider)
                                                     && sd.ImplementationType == typeof(UowProvider))
                .ToArray();
            Assert.Equal(1, registrations.Count());
            Assert.Equal(ServiceLifetime.Singleton, registrations[0].Lifetime);
        }
        [Fact]
        private void GenericRepositoryIsRegisteredAsTransient()
        {
            var services = new ServiceCollection();

            services.AddDataAccess<TestContext>();

            var registrations = services.Where(sd => sd.ServiceType == typeof(IRepository<>)
                                                     && sd.ImplementationType == typeof(GenericEntityRepository<>))
                .ToArray();
            Assert.Equal(1, registrations.Count());
            Assert.Equal(ServiceLifetime.Transient, registrations[0].Lifetime);
        }

        [Fact]
        private void DataPagerIsRegisteredAsTransient()
        {
            var services = new ServiceCollection();

            services.AddDataAccess<TestContext>();

            var registrations = services.Where(sd => sd.ServiceType == typeof(IDataPager<>)
                                                     && sd.ImplementationType == typeof(DataPager<>))
                .ToArray();
            Assert.Equal(1, registrations.Count());
            Assert.Equal(ServiceLifetime.Transient, registrations[0].Lifetime);
        }
    }
}