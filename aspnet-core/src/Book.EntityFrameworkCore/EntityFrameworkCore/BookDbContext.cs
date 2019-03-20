using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Book.Authorization.Roles;
using Book.Authorization.Users;
using Book.MultiTenancy;
using Book.Books.Persons;
using Book.Books.PhoneNumbers;

namespace Book.EntityFrameworkCore
{
    public class BookDbContext : AbpZeroDbContext<Tenant, Role, User, BookDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BookDbContext(DbContextOptions<BookDbContext> options)
            : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //生成PB.Person的数据表
            modelBuilder.Entity<Person>().ToTable("Persoon", "PB");
            //生成PB.PhoneNumber的数据表
            modelBuilder.Entity<PhoneNumber>().ToTable("PhoneNumber", "PB");
            base.OnModelCreating(modelBuilder);
        }
    }
}
