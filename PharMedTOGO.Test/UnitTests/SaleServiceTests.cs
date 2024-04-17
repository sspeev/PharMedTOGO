using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Core.Services;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace PharMedTOGO.Test.UnitTests
{
    [TestFixture]
    public class SaleServiceTests : UnitTestsBase
    {
        private ISaleService saleService;
        private IMedicineService medicineService;

        [OneTimeSetUp]
        public void SetUp()
        {
            medicineService = new MedicineService(context);
            saleService = new SaleService(context, medicineService);
        }

        [Test]
        public async Task All()
        {
            var query = await saleService.AllAsync();
            Assert.IsNotNull(query);


            int salesCount = query.TotalSales;
            Assert.AreEqual(query.Sales.Count(), salesCount);


            var sale = query.Sales.First(s => s.Id == 2);
            Assert.AreEqual(seed.Sale2.Discount, sale.Discount);
        }

        [Test]
        public async Task Create()
        {
            var sale = new SaleFormModel()
            {
                Discount = 70,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(10),
            };
            await saleService.CreateAsync(sale);
            var sales = await saleService.AllAsync();
            Assert.AreEqual(4, sales.TotalSales);
        }

        [Test]
        public async Task ExistsAndNot()
        {
            Assert.AreEqual(true, await saleService.ExistsByIdAsync(1));

            Assert.AreEqual(false, await saleService.ExistsByIdAsync(5));
        }

        [Test]
        public async Task MapToService()
        {
            var sale = await saleService.MapByIdSale(2);

            Assert.AreEqual(2, sale.Id);
        }

        [Test]
        public async Task CheckSaleDates()//!
        {
            await saleService.AttachMedicine(1, 1);
            var medicines = await medicineService.AllAsync();
            await saleService.CheckSaleDates(medicines.Medicines);

            var first = medicines.Medicines.First();

            Assert.AreEqual(4, first.Price);
        }

        [Test]
        public async Task AttachPriceTest()
        {
            await saleService.AttachMedicine(1, 1);
            var medicine = await medicineService.FindByIdAsync(1);//nurofen

            Assert.AreEqual(4, medicine.Price);
        }

        [Test]
        public async Task AttachDateTest()
        {
            var model = new SaleFormModel()
            {
                Discount = 50,
                StartDate = DateTime.Now.AddDays(1),
                EndDate = DateTime.Now.AddDays(2),
            };
            await saleService.CreateAsync(model);

            await saleService.AttachMedicine(3, 1);
            var medicine2 = await medicineService.FindByIdAsync(1);

            Assert.AreEqual(8, medicine2.Price);
        }

        [Test]
        public async Task Delete()
        {
            await saleService.DeleteAsync(3);
            var sales = await saleService.AllAsync();

            Assert.AreEqual(3, sales.TotalSales);
        }

        [Test]
        public async Task Edit()
        {
            var model = new SaleFormModel()
            {
                Discount = 90,
                StartDate = DateTime.Now.AddDays(1),
                EndDate = DateTime.UtcNow.AddDays(2),
            };
            await saleService.EditAsync(2, model);

            var sale = await saleService.FindByIdAsync(2);

            Assert.AreEqual(model.Discount, sale.Discount);
        }

        [OneTimeTearDown]
        public void TearDownBase() => context.Dispose();
    }
}
