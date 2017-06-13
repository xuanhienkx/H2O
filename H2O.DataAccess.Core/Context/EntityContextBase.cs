using Microsoft.EntityFrameworkCore;

namespace H2O.DataAccess.Core.Context
{
	public class EntityContextBase<TContext> : DbContext, IEntityContext where TContext : DbContext
	{
		public EntityContextBase(DbContextOptions<TContext> options) : base((DbContextOptions) options)
		{
		}
	}

}