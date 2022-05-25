using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace StandardShared.Database;

public class BaseDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public BaseDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
        Database.EnsureCreated();
    }

}