using Microsoft.EntityFrameworkCore;

namespace H2O.DataAccess.Core.Uow
{
	public interface IUowProvider
	{
		IUnitOfWork CreateUnitOfWork(bool trackChanges = true, bool enableLogging = false);
		IUnitOfWork CreateUnitOfWork<TEntityContext>(bool trackChanges = true, bool enableLogging = false) where TEntityContext : DbContext;

	}
}