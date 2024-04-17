using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Enumerations;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Core.Services;
using PharMedTOGO.Infrastrucure.Data.Enums;

namespace PharMedTOGO.Test.UnitTests
{
    [TestFixture]
    public class MedicineServiceTests : UnitTestsBase
    {
        private IMedicineService medicineService;


        [OneTimeSetUp]
        public void SetUp() 
        {
            medicineService = new MedicineService(context);
        }

        [Test]
        public async Task AllIsNull()
        {
            var query = await medicineService.AllAsync();
            Assert.IsNotNull(query);


            int medicineCount = query.MedicinesCount;
            Assert.AreEqual(query.Medicines.Count(), medicineCount);


            var medicine = query.Medicines.First(m => m.Id == 3);
            Assert.AreEqual(seed.Medicine3.Name, medicine.Name);
        }

        [Test]
        public async Task AllSortingCheckSearchTerm()
        {
            var medicines = await medicineService.AllAsync();
            var medicinesSorted = medicineService.AllSorted(
                "Буск",
                MedicineSorting.Newest,
                1, 5, medicines);

            var firstMed = medicinesSorted.Medicines.First().Name;

            Assert.AreEqual("Бусколизин", firstMed);
        }

        [Test]
        public async Task AllSortingCheckEnum()
        {
            var medicines = await medicineService.AllAsync();
            var medicinesSorted = medicineService.AllSorted(null,
                MedicineSorting.Cosmetics,
                1, 5, medicines);

            var firstMed = medicinesSorted.Medicines.First().Name;

            Assert.AreEqual("Мокри кърпи БОЧКО", firstMed);
        }

        [Test]
        public async Task Create()
        {
            var model = new MedicineFormModel()
            {
                Name = "Test",
                Category = MedicineCategory.General,
                ImageUrl = "test",
                Price = 12.6m,
                RequiresPrescription = true,
                Description = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
            };
            await medicineService.CreateAsync(model);

            var result = await medicineService.AllAsync();

            Assert.AreEqual(6, result.MedicinesCount);
        }

        [Test]
        public async Task ExistsAndNotExists()
        {
            Assert.AreEqual(true, await medicineService.ExistsByIdAsync(4));

            Assert.AreEqual(false, await medicineService.ExistsByIdAsync(11));
        }

        [Test]
        public async Task Delete()
        {
            await medicineService.DeleteAsync(2);
            var medicines = await medicineService.AllAsync();

            Assert.AreEqual(5, medicines.MedicinesCount);
        }

        [Test]
        public async Task Edit()
        {
            var model = new MedicineFormModel()
            {
                Name = "Nurofen",
                RequiresPrescription = false,
                Category = MedicineCategory.General,
                ImageUrl = "https://subra.bg/files/richeditor/os-product-images/11/nurofen-24-200mg.jpg",
                Price = 8m,
                Description = "Главоболие и температура",
            };
            await medicineService.EditAsync(3, model);

            var medicine = await medicineService.FindByIdAsync(3);

            Assert.AreEqual(model.Name, medicine.Name);
        }

        [Test]
        public async Task Details()
        {
            var medicine = await medicineService.MedicineDetails(3);

            Assert.AreEqual(3, medicine.Id);
        }

        [OneTimeTearDown]
        public void TearDownBase() => context.Dispose();
    }
}
