using System.ComponentModel.DataAnnotations;

namespace H2O.DataAccess.Core.Entities
{
	public class EntityBase
	{
		// This is the base class for all entities.
		// The DataAccess repositories have this class as constraint for entities that are persisted in the database.
	    [Key]
		public int Id { get; set; }
	}
}