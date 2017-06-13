using H2O.DataAccess.Core.Context;
using Microsoft.EntityFrameworkCore;

namespace H2O.DataAccess.Core.Test._TestObjects
{
    public class TestContext : EntityContextBase<TestContext>
    {
        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        { }
    }
}
