using H2O.DataAccess.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace H2O.DataAccess.Core.Repositories
{
	public class GenericEntityRepository<TEntity> : EntityRepositoryBase<DbContext, TEntity> where TEntity : EntityBase, new()
	{
		public GenericEntityRepository(ILogger<DataAccess> logger) : base(logger, null)
		{ }
	}
}