using Microsoft.EntityFrameworkCore;

namespace BulkProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Whatever options we configure in Contractor will pass passed to the base class of DbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) 
        {
            
        }
    }
}
