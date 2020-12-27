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
                .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            var connectionString = configuration.GetConnectionString("Academy");

            var optionsBuilder = new DbContextOptionsBuilder<AcademyDbContext>();
            
            optionsBuilder.UseSqlServer(connectionString);

            return new AcademyDbContext(optionsBuilder.Options);
        }
    }
}