using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Services;

namespace PharMedTOGO.Test.UnitTests
{
    [TestFixture]
    public class AdminServiceTests : UnitTestsBase
    {
        private IAdminService adminService;
        private IPrescriptionService prescriptionService;


        [OneTimeSetUp]
        public void SetUp()
        {
            prescriptionService = new PrescriptionService(context);
            adminService = new AdminService(context, prescriptionService);
        }

        [Test]
        public async Task AllUsers()
        {
            var query = await adminService.AllUsersAsync();
            Assert.IsNotNull(query);


            int medicineCount = query.Count();
            Assert.AreEqual(2, medicineCount);


            var medicine = query.First(m => m.Id == "1af310c7-3350-4886-ba31-fcdc3f4cfff5");
            Assert.AreEqual(seed.Patient1.FirstName, medicine.FirstName);
        }

        [OneTimeTearDown]
        public void TearDownBase() => context.Dispose();
    }
}
