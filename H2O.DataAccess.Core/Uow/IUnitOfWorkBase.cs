using System;
using System.Threading;
using System.Threading.Tasks;
using H2O.DataAccess.Core.Repositories;

namespace H2O.DataAccess.Core.Uow
{
	public interface IUnitOfWorkBase : IDisposable
	{
		int SaveChanges();
		Task<int> SaveChangesAsync();
		Task<int> SaveChangesAsync(CancellationToken cancellationToken);

		IRepository<TEntity> GetRepository<TEntity>();
		TRepository GetCustomRepository<TRepository>();
	}
}