using Microsoft.AspNetCore.Identity;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace PharMedTOGO.Infrastrucure.Seed
{
    public class SeedData
    {
        public Prescription Prescription1 { get; set; } = null!;

        public Prescription Prescription2 { get; set; } = null!;

        public Patient Patient1 { get; set; } = null!;

        public Patient Patient2 { get; set; } = null!;

        public IdentityUser User1 { get; set; }

        public IdentityUser User2 { get; set; }

        public SeedData()
        {
            SeedUsers();
            SeedPatients();
            SeedPrescriptions();
        }

        private void SeedPrescriptions()
        {
            Prescription1 = new Prescription()
            {
                Id = 1,
                IsValidated = true,
                CreatedOn = DateTime.UtcNow,
                ExpireDate = DateTime.Now.AddDays(10),
                Description = "Grip",
                PatientId = Patient2.Id
            };

            Prescription2 = new Prescription()
            {
                Id = 2,
                IsValidated = false,
                CreatedOn = DateTime.UtcNow.AddDays(-11),
                ExpireDate = DateTime.Now,
                Description = "COVID-19",
                PatientId = Patient2.Id
            };
        }

        private void SeedPatients()
        {
            Patient1 = new Patient()
            {
                Id = 1,
                FirstName = "Stoyan",
                LastName = "Peev",
                EGN = "1234567890",
                Address = "Burgas-Slaveikov",
                UserId = "d42ae752-35a7-4ba3-a9c0-190484b6c253"
            };

            Patient2 = new Patient()
            {
                Id = 2,
                FirstName = "Kristalin",
                LastName = "Zhelezhchev",
                EGN = "908765432",
                Address = "Pomorie-Mahala-N1",
                UserId = "3fe16750-157b-4110-a05f-0d2ba0812b3c"
            };
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();
            User1 = new IdentityUser()
            {
                Id = "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                UserName = "Stoyan",
                Email = "stoyan@mail.com",
                PasswordHash = hasher.HashPassword(User1, "123456")
            };

            User2 = new IdentityUser()
            {
                Id = "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                UserName = "Kristalin",
                Email = "kristalin@mail.com",
                PasswordHash = hasher.HashPassword(User2, "123456")
            };
        }
    }
}
