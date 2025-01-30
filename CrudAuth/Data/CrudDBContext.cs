using CrudAuth.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CrudAuth.Data
{
    /*
     * CrudDBContext inherits from IdentityDbContext type of User
     * which means that it already comes with Identity support
     *  >>Authentication and User Management <<
     *  AND we're including the DBSet of Product which will be used to do
     *  CRUD operations in the Products
    */
    public class CrudDBContext : IdentityDbContext<User>
    {
        public CrudDBContext(DbContextOptions<CrudDBContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
