using Microsoft.EntityFrameworkCore;

namespace ConceptAPI.Data
{
    public class AdventureWorksDbContext : DbContext
    {
        public AdventureWorksDbContext()
        {
        }

        public AdventureWorksDbContext(DbContextOptions<AdventureWorksDbContext> options)
            : base(options)
        {

        }
    }
}
