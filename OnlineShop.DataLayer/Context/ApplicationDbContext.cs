using Microsoft.EntityFrameworkCore;

namespace OnlineShop.DataLayer.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }
}
