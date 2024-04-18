using PharMedTOGO.Infrastrucure.Data;
using PharMedTOGO.Test.Mock;

namespace PharMedTOGO.Test.UnitTests
{
    public class UnitTestsBase
    {
        protected PharMedDbContext context;
        protected Seed seed = new();

        [OneTimeSetUp]
        public void SetUpBase()
        {
            context = DatabaseMock.Instance;
            seed.SeedDatabase(context);
        }
    
    }
}
