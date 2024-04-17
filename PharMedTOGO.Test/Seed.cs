using PharMedTOGO.Infrastrucure.Data;
using PharMedTOGO.Infrastrucure.Data.Enums;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace PharMedTOGO.Test
{
    public class Seed
    {
        public Patient Patient1 { get; private set; } = null!;
        public Patient Patient2 { get; private set; } = null!;

        public Prescription Prescription1 { get; private set; } = null!;
        public Prescription Prescription2 { get; private set; } = null!;

        public Medicine Medicine1 { get; private set; } = null!;
        public Medicine Medicine2 { get; private set; } = null!;
        public Medicine Medicine3 { get; private set; } = null!;
        public Medicine Medicine4 { get; private set; } = null!;
        public Medicine Medicine5 { get; private set; } = null!;
        public Medicine Medicine6 { get; private set; } = null!;

        public Sale Sale1 { get; private set; } = null!;
        public Sale Sale2 { get; private set; } = null!;
        public Sale Sale3 { get; private set; } = null!;


        public void SeedDatabase(PharMedDbContext context)
        {
            Patient1 = new Patient()
            {
                Id = "1af310c7-3350-4886-ba31-fcdc3f4cfff5",
                UserName = "stoyan@mail.com",
                Email = "stoyan@mail.com",
                FirstName = "Stoyan",
                LastName = "Peev",
                EGN = "0549050487",
                Address = "Burgas-Slaveikov",
                EmailConfirmed = true,
                PasswordHash = "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92",
                SecurityStamp = "a28d42e9-9d71-4503-ba94-4d1378e237de",
                ConcurrencyStamp = "713add2c-73f2-4424-b6ae-ee485061d387",
                TwoFactorEnabled = false
            };
            Patient1.NormalizedEmail = Patient1.Email.ToUpper();
            Patient1.NormalizedUserName = Patient1.UserName.ToUpper();

            Patient2 = new Patient()
            {
                Id = "94df08a3-eecf-461d-bfd4-64e91fbf0fe4",
                UserName = "kristian@mail.com",
                Email = "kristian@mail.com",
                FirstName = "Kristian",
                LastName = "Petrov",
                EGN = "0538932194",
                Address = "Vazrazhdane",
                EmailConfirmed = true,
                PasswordHash = "8bb0cf6eb9b17d0f7d22b456f121257dc1254e1f01665370476383ea776df414",
                SecurityStamp = "3489320f-1999-4260-847e-0ba7dadf3057",
                ConcurrencyStamp = "4c7346de-21fd-49ed-b7bb-dd700a6bfe76",
                TwoFactorEnabled = false
            };
            Patient2.NormalizedEmail = Patient2.Email.ToUpper();
            Patient2.NormalizedUserName = Patient2.UserName.ToUpper();

            context.Users.Add(Patient1);
            context.Users.Add(Patient2);




            Prescription1 = new Prescription()
            {
                Id = 1,
                PrescriptionState = PrescriptionState.NotReviewed,
                CreatedOn = DateTime.Now,
                ExpireDate = DateTime.Now.AddDays(10),
                Description = "Flu",
                PatientId = Patient1.Id
            };

            Prescription2 = new Prescription()
            {
                Id = 2,
                PrescriptionState = PrescriptionState.NotReviewed,
                CreatedOn = DateTime.UtcNow.AddDays(-11),
                ExpireDate = DateTime.Now,
                Description = "COVID-19",
                PatientId = Patient2.Id
            };

            context.Prescriptions.Add(Prescription1);
            context.Prescriptions.Add(Prescription2);






            Medicine1 = new Medicine()
            {
                Id = 1,
                Name = "Нурофен",
                RequiresPrescription = false,
                Category = MedicineCategory.General,
                ImageUrl = "https://subra.bg/files/richeditor/os-product-images/11/nurofen-24-200mg.jpg",
                Price = 8m,
                HasSaleApplied = false,
                Description = "Главоболие и температура",
                SaleId = null
            };

            Medicine2 = new Medicine()
            {
                Id = 2,
                Name = "Беналгин",
                RequiresPrescription = false,
                Category = MedicineCategory.General,
                ImageUrl = "https://sopharmacy.bg/media/sys_master/h3b/h9d/9063126761502.jpg",
                Price = 11.16m,
                HasSaleApplied = false,
                Description = "Главоболие",
                SaleId = null
            };

            Medicine3 = new Medicine()
            {
                Id = 3,
                Name = "Бусколизин",
                RequiresPrescription = false,
                Category = MedicineCategory.General,
                ImageUrl = "https://static.framar.bg/product/sopharma-buskolizin-tabletki-bolezneni-spazmi-hioscinov-butilbromid.jpg",
                Price = 11.16m,
                HasSaleApplied = false,
                Description = "При раздразнен стомах и диария",
                SaleId = null
            };

            Medicine4 = new Medicine()
            {
                Id = 4,
                Name = "Цинабсин",
                RequiresPrescription = false,
                Category = MedicineCategory.Homeophatic,
                ImageUrl = "https://alpenpharma-bulgaria.bg/wp-content/uploads/2021/02/cinabsin-1.png",
                Price = 17m,
                HasSaleApplied = false,
                Description = "Хрема, запушен нос и синузит",
                SaleId = null
            };
            Medicine5 = new Medicine()
            {
                Id = 5,
                Name = "Мокри кърпи БОЧКО",
                RequiresPrescription = false,
                Category = MedicineCategory.Cosmetics,
                ImageUrl = "https://depobebemag.bg/wp-content/uploads/2019/02/%D0%B1%D0%BE%D1%87%D0%BA%D0%BE-%D0%BC%D0%BE%D0%BA%D1%80%D0%B8-%D0%BA%D1%8A%D1%80%D0%BF%D0%B8-%D1%81%D0%BC%D1%80%D0%B0%D0%B4%D0%BB%D0%B8%D0%BA%D0%B0-90%D0%B1%D1%80.png",
                Price = 2.6m,
                HasSaleApplied = false,
                Description = string.Empty,
                SaleId = null
            };

            Medicine6 = new Medicine()
            {
                Id = 6,
                Name = "test",
                RequiresPrescription = false,
                Category = MedicineCategory.General,
                ImageUrl = "https://subra.bg/files/richeditor/os-product-images/11/nurofen-24-200mg.jpg",
                Price = 8m,
                HasSaleApplied = false,
                Description = "Главоболие и температура",
                SaleId = null
            };

            context.Medicines.Add(Medicine1);
            context.Medicines.Add(Medicine2);
            context.Medicines.Add(Medicine3);
            context.Medicines.Add(Medicine4);
            context.Medicines.Add(Medicine5);




            Sale1 = new Sale()
            {
                Id = 1,
                Discount = 50,
                StartDate = DateTime.Now.Date,
                EndDate = DateTime.Now.Date.AddDays(1),
                IsEnded = false
            };

            Sale2 = new Sale()
            {
                Id = 2,
                Discount = 30,
                StartDate = DateTime.Now.Date,
                EndDate = DateTime.Now.Date.AddDays(10),
                IsEnded = false
            };

            Sale3 = new Sale()
            {
                Id = 3,
                Discount = 30,
                StartDate = DateTime.Now.Date,
                EndDate = DateTime.Now.Date.AddDays(10),
                IsEnded = false
            };

            context.Sales.Add(Sale1);
            context.Sales.Add(Sale2);

            context.SaveChanges();
        }
    }
}