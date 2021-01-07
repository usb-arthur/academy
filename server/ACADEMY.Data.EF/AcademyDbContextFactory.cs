using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ACADEMY.Data.EF
{
    internal class AcademyDbContextFactory : IDesignTimeDbContextFactory<AcademyDbContext>
    {
        public AcademyDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddUserSecrets("ab91a7f8-09ba-45c3-9c51-386f6e39e5e8")
                .Build();

            var connectionString = configuration.GetConnectionString("Academy");

            var optionsBuilder = new DbContextOptionsBuilder<AcademyDbContext>();

            optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("ACADEMY.WebApi"));

            return new AcademyDbContext(optionsBuilder.Options);
        }
    }
}