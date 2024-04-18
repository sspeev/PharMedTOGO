using Microsoft.AspNetCore.Identity;
using PharMedTOGO.Infrastrucure.Data.Enums;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace PharMedTOGO.Infrastrucure.Seed
{
    public class SeedData
    {
        public Prescription Prescription1 { get; set; } = null!;

        public Prescription Prescription2 { get; set; } = null!;

        public Patient Patient1 { get; set; } = null!;

        public Patient Patient2 { get; set; } = null!;

        public Medicine Medicine1 { get; set; } = null!;

        public Medicine Medicine2 { get; set; } = null!;

        public Medicine Medicine3 { get; set; } = null!;

        public Medicine Medicine4 { get; set; } = null!;

        public Medicine Medicine5 { get; set; } = null!;

        public Medicine Medicine6 { get; set; } = null!;

        public Medicine Medicine7 { get; set; } = null!;

        public Sale Sale1 { get; set; } = null!;

        public Sale Sale2 { get; set; } = null!;

        public List<IdentityRole> Roles { get; set; } = new List<IdentityRole>();

        public List<IdentityUserRole<string>> UsersRoles { get; set; } = new List<IdentityUserRole<string>>();

        public SeedData()
        {
            SeedSales();
            SeedMedicines();
            SeedPrescriptions();
            SeedPatients();
            SeedRoles();
            SeedUsersRoles();
        }

        private void SeedMedicines()
        {
            Medicine1 = new Medicine()
            {
                Id = 1,
                Name = "Нурофен",
                RequiresPrescription = false,
                Category = MedicineCategory.General,
                ImageUrl = "https://subra.bg/files/richeditor/os-product-images/11/nurofen-24-200mg.jpg",
                Price = 7.98m,
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
                Name = "Шипково масло с Омега 3, 6 и 9",
                RequiresPrescription = false,
                Category = MedicineCategory.FoodAdditives,
                ImageUrl = "https://balevski.eu/cdn/shop/files/18-3._3-6-9.jpg?v=1688235019&width=823",
                Price = 34.9m,
                HasSaleApplied = false,
                Description = "Продуктът предлага цялостна подкрепа за организма, особено през есенно-зимния сезон. Той укрепва имунната система благодарение на незаменимите мастни киселини и мощното антиоксидантно действие. Също така, стимулира метаболизма и помага на тялото да се справи със стреса. Подпомага сърдечно-съдовата система и умствената дейност, допринася за намаляване на умората и изтощението, и спомага за предпазването на клетките от окислителен стрес.",
                SaleId = null
            };
            Medicine7 = new Medicine()
            {
                Id = 7,
                Name = "Сумамед",
                RequiresPrescription = true,
                Category = MedicineCategory.General,
                ImageUrl = "https://uploads.remediumapi.com/5ecc3d1b6af72c3ad4d460e1/103/257fe60e2311dced12194a77b5f7ffd2/720.jpeg",
                Price = 17.6m,
                HasSaleApplied = false,
                Description = "Сумамед съдържа азитромицин, който принадлежи към групата на антибактериалните лекарствени продукти за системно приложение, макролиден антибиотик.\r\n\r\nСумамед се прилага за лечение на пациенти с инфекции, причинени от един или повече от един чувствителни на азитромицин микроорганизми:\r\n\r\nинфекции на горните дихателни пътища: фарингит/тонзилит, синуит и възпаление на средното ухо\r\nинфекции на долните дихателни пътища: бронхит и пневмонии, придобити в обществото \r\nинфекции на кожата и меките тъкани: средно изразена форма на acne vulgaris, еритема хроника мигранс (първи стадий на Лаймска болест), еризипел, импетиго и вторична пиодермия\r\nполово предавани болести: неусложнени генитални инфекции причинени от Chlamydia trachomatis",
                SaleId = null
            };
        }

        private void SeedPrescriptions()
        {
            Prescription1 = new Prescription()
            {
                Id = 1,
                PrescriptionState = PrescriptionState.NotReviewed,
                CreatedOn = DateTime.Now,
                ExpireDate = DateTime.Now.AddDays(10),
                Description = "Flu"
            };

            Prescription2 = new Prescription()
            {
                Id = 2,
                PrescriptionState = PrescriptionState.NotReviewed,
                CreatedOn = DateTime.UtcNow.AddDays(-11),
                ExpireDate = DateTime.Now,
                Description = "COVID-19"
            };
        }

        private void SeedPatients()
        {
            var hasher = new PasswordHasher<IdentityUser>();
            Patient1 = new Patient()
            {
                Id = "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                UserName = "admin@mail.com",
                Email = "admin@mail.com",
                FirstName = "Admin",
                LastName = "Adminov",
                EGN = "0549050487",
                Address = "Burgas-Slaveikov",
                PrescriptionId = Prescription1.Id,
            };
            Patient1.NormalizedEmail = Patient1.Email.ToUpper();
            Patient1.NormalizedUserName = Patient1.UserName.ToUpper();
            Patient1.PasswordHash = hasher.HashPassword(Patient1, "123456");

            Patient2 = new Patient()
            {
                Id = "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                UserName = "test@mail.com",
                Email = "test@mail.com",
                FirstName = "Test",
                LastName = "Testov",
                EGN = "0506047819",
                Address = "Pomorie-Mahala-N1",
                PrescriptionId = Prescription2.Id
            };
            Patient2.NormalizedEmail = Patient2.Email.ToUpper();
            Patient2.NormalizedUserName = Patient2.UserName.ToUpper();
            Patient2.PasswordHash = hasher.HashPassword(Patient2, "123456");
        }

        private void SeedRoles()
        {
            var AdminRole = new IdentityRole()
            {
                Id = "9fb66dc7-697a-48fc-a009-3169578464bc",
                Name = "Admin"
            };
            AdminRole.NormalizedName = AdminRole.Name.ToUpper();

            Roles.Add(AdminRole);
        }

        private void SeedUsersRoles()
        {
            var Admin = new IdentityUserRole<string>()
            {
                RoleId = "9fb66dc7-697a-48fc-a009-3169578464bc",
                UserId = "d42ae752-35a7-4ba3-a9c0-190484b6c253"
            };

            UsersRoles.Add(Admin);
        }

        private void SeedSales()
        {
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
        }
    }
}
