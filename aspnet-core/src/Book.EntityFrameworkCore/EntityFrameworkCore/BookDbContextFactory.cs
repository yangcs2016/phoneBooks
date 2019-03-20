using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Book.Configuration;
using Book.Web;

namespace Book.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class BookDbContextFactory : IDesignTimeDbContextFactory<BookDbContext>
    {
        public BookDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BookDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            BookDbContextConfigurer.Configure(builder, configuration.GetConnectionString(BookConsts.ConnectionStringName));

            return new BookDbContext(builder.Options);
        }
    }
}
