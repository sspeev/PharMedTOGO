using Microsoft.EntityFrameworkCore;
using PharMedTOGO.Infrastrucure.Data;

namespace PharMedTOGO.Test.Mock
{
    public static class DatabaseMock
    {
        public static PharMedDbContext Instance
        {
            get
            {
                var contextOptions = new DbContextOptionsBuilder<PharMedDbContext>()
                .UseInMemoryDatabase("PharMedInMemory" + Guid.NewGuid().ToString())
                .Options;

                var context = new PharMedDbContext(contextOptions, false);
                context.Database.EnsureCreated();
                return context;
            }
        }
    }
}
