using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {
        }
    }
}