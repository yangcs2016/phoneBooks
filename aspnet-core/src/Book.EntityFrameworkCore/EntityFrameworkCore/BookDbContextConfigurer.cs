using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Book.EntityFrameworkCore
{
    public static class BookDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BookDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BookDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
