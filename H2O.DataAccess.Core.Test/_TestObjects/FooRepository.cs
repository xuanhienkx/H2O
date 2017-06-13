using H2O.DataAccess.Core.Repositories;
using Microsoft.Extensions.Logging;

namespace H2O.DataAccess.Core.Test._TestObjects
{
    public class FooRepository : EntityRepositoryBase<InMemoryContext, Foo>, IFooRepository
    {
        public FooRepository(ILogger<DataAccess> logger, InMemoryContext context) : base(logger, context)
        {
        }
    }
}
