using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Services;
using PharMedTOGO.Infrastrucure.Data.Enums;

namespace PharMedTOGO.Test.UnitTests
{
    [TestFixture]
    public class PrescriptionServiceTests : UnitTestsBase
    {
        private IPrescriptionService prescriptionService;


        [OneTimeSetUp]
        public void SetUp()
        {
            prescriptionService = new PrescriptionService(context);
        }

        [Test]
        public async Task All()
        {
            var query = await prescriptionService.AllAsync();
            Assert.IsNotNull(query);


            int medicineCount = query.Count();
            Assert.AreEqual(2, medicineCount);


            var medicine = query.First(m => m.Id == 1);
            Assert.AreEqual(seed.Prescription1.Description, medicine.Description);
        }


        [Test]
        public async Task Details()
        {
            var prescription = await prescriptionService.DetailsAsync(2);

            Assert.AreEqual(2, prescription.Id);
        }

        [Test]
        public async Task ExistsAndNot()
        {
            Assert.AreEqual(true, await prescriptionService.ExistsByIdAsync(2));

            Assert.AreEqual(false, await prescriptionService.ExistsByIdAsync(11));
        }

        [Test]
        public async Task Validate()
        {
            await prescriptionService.ValidatePrescriptionAsync(1);
            var prescription = await prescriptionService.FindByIdAsync(1);
            Assert.AreEqual(PrescriptionState.Reviewing, prescription.PrescriptionState);
        }

        [OneTimeTearDown]
        public void TearDownBase() => context.Dispose();
    }
}
