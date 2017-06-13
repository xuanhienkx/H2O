using Microsoft.EntityFrameworkCore;

namespace H2O.DataAccess.Core.Repositories
{
	public interface IRepositoryInjection
	{
		IRepositoryInjection SetContext(DbContext context);
	}
}