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

                return new PharMedDbContext(contextOptions, false);
            }
        }
    }
}
