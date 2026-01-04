using CQRS_MediatRWebApiProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS_MediatRWebApiProject.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options ) : DbContext(options)
    {
        public DbSet<GameInfo> GameInfos => Set<GameInfo>();   
    }
}
