using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Services;

namespace PharMedTOGO.Test.UnitTests
{
    [TestFixture]
    public class CartServiceTests : UnitTestsBase
    {
        private ICartService cartService;


        [OneTimeSetUp]
        public void SetUp()
        {
            cartService = new CartService(context);
        }

        [Test]
        public async Task All()
        {
            var query = await cartService.AllCartProducts("1af310c7-3350-4886-ba31-fcdc3f4cfff5");
            Assert.IsNotNull(query);


            int medicineCount = query.Medicines.Count();
            Assert.AreEqual(1, medicineCount);


            var medicine = query.Medicines.First(m => m.Id == 1);
            Assert.AreEqual(seed.Medicine1.Name, medicine.Name);
        }

        [Test]
        public async Task Add()
        {
            await cartService.AddToCartAsync(1, "1af310c7-3350-4886-ba31-fcdc3f4cfff5");
            
            var carts = await cartService.AllCartProducts("1af310c7-3350-4886-ba31-fcdc3f4cfff5");
            int countAfterAdd = carts.Medicines.Count;

            Assert.AreEqual(1, countAfterAdd);
        }
        [OneTimeTearDown]
        public void TearDownBase() => context.Dispose();
    }
}
