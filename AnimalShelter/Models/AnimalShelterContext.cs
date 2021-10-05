using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalShelterContext(DbContextOptions options) : base(options) { }
  }
}

// MySqlException: Unknown column 'a.ThisTypes' in 'field list'
// MySqlConnector.Core.ResultSet.ReadResultSetHeaderAsync(IOBehavior ioBehavior) in ResultSet.cs, line 49

// MySqlException: Unknown column 'a.ThisTypes' in 'field list'
// MySqlConnector.MySqlDataReader.ActivateResultSet(CancellationToken cancellationToken) in MySqlDataReader.cs, line 131
