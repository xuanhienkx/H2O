using System;
using System.Collections.Generic;

namespace H2O.DataAccess.Core.Paging
{
	public class DataPage<TEntity>
	{
		public IEnumerable<TEntity> Data { get; set; }
		public long TotalEntityCount { get; set; }

		public int PageNumber { get; set; }
		public int PageLength { get; set; }

		public int TotalPageCount
		{
			get
			{
				return Convert.ToInt32(Math.Ceiling((decimal)TotalEntityCount / PageLength));
			}
		}
	}
}