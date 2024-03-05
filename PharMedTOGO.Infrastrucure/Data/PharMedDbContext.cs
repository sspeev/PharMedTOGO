using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PharMedTOGO.Data
{
    public class PharMedDbContext : IdentityDbContext
    {
        public PharMedDbContext(DbContextOptions<PharMedDbContext> options)
            : base(options)
        {

        }
    }
}
