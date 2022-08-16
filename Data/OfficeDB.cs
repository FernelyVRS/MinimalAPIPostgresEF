using Microsoft.EntityFrameworkCore;
using MinimalAPI_PostgresEF.Models;

namespace MinimalAPI_PostgresEF.Data
{
    public class OfficeDB : DbContext
    {

        public OfficeDB(DbContextOptions<OfficeDB> options) : base(options)
        {

        }

        public DbSet<Employee> Employees => Set<Employee>();
    }
}
