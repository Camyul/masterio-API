using Masterio.Server.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Masterio.Server.Data;

public class MasterioDbContext : IdentityDbContext<User>
{
    public MasterioDbContext(DbContextOptions<MasterioDbContext> options)
        : base(options)
    {
    }
}
 