using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace WEB.Models
{
    public class BerberContext:DbContext
    {
        // Constructor
        public BerberContext(DbContextOptions<BerberContext> options) : base(options)
        {
        }
        public DbSet<Hizmet> Hizmetler { get; set; }
        public DbSet<Randevu> Randevular { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Salon> Salonlar { get; set; }
        public DbSet<Calisan> Calisanlar { get; set; }
        public DbSet<CalismaSaati> CalismaSaatleri { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Password hashing için PasswordHasher
            //var passwordHasher = new PasswordHasher<User>();

            //// Kullanıcılar
            //modelBuilder.Entity<User>().HasData(
            //    new User
            //    {
            //        Id = 1,
            //        Name = "Ahmet Yılmaz",
            //        Phone = "05331234567",
            //        Email = "ahmet.yilmaz@gmail.com",
            //        PasswordHash = passwordHasher.HashPassword(null, "Ahmet123!")
            //    },
            //    new User
            //    {
            //        Id = 2,
            //        Name = "Ayşe Demir",
            //        Phone = "05339876543",
            //        Email = "ayse.demir@gmail.com",
            //        PasswordHash = passwordHasher.HashPassword(null, "Ayse123!")
            //    },
            //    new User
            //    {
            //        Id = 3,
            //        Name = "Fatma Çelik",
            //        Phone = "05431234567",
            //        Email = "fatma.celik@gmail.com",
            //        PasswordHash = passwordHasher.HashPassword(null, "Fatma123!")
            //    },
            //    new User
            //    {
            //        Id = 4,
            //        Name = "Mehmet Kara",
            //        Phone = "05439876543",
            //        Email = "mehmet.kara@gmail.com",
            //        PasswordHash = passwordHasher.HashPassword(null, "Mehmet123!")
            //    },
            //    new User
            //    {
            //        Id = 5,
            //        Name = "Ali Can",
            //        Phone = "05551234567",
            //        Email = "ali.can@gmail.com",
            //        PasswordHash = passwordHasher.HashPassword(null, "Ali123!")
            //    }
            //);


            //// Hizmetler
            //modelBuilder.Entity<Hizmet>().HasData(
            //    new Hizmet { Id = 1, Name = "Saç Kesimi", DurationMinutes = 30, Price = 50 },
            //    new Hizmet { Id = 2, Name = "Manikür", DurationMinutes = 45, Price = 80 },
            //    new Hizmet { Id = 3, Name = "Pedikür", DurationMinutes = 60, Price = 100 },
            //    new Hizmet { Id = 4, Name = "Saç Boyama", DurationMinutes = 90, Price = 200 },
            //    new Hizmet { Id = 5, Name = "Cilt Bakımı", DurationMinutes = 120, Price = 150 }
            //);

            //// Salonlar
            //modelBuilder.Entity<Salon>().HasData(
            //    new Salon { Id = 1, Name = "Elite Güzellik Salonu", Location = "İstanbul", ContactNumber = "02124567890" },
            //    new Salon { Id = 2, Name = "Lüks Kuaför", Location = "Ankara", ContactNumber = "03124567890" },
            //    new Salon { Id = 3, Name = "Güzellik Merkezi", Location = "İzmir", ContactNumber = "02324567890" },
            //    new Salon { Id = 4, Name = "Bakım ve Spa", Location = "Antalya", ContactNumber = "02424567890" },
            //    new Salon { Id = 5, Name = "Zen Saç Stüdyosu", Location = "Bursa", ContactNumber = "02224567890" }
            //);

            //// Çalışanlar
            //modelBuilder.Entity<Calisan>().HasData(
            //    new Calisan { Id = 1, Name = "Zeynep Aydın", SalonId = 1, Position = "Kuaför", ExperienceYears = 5 },
            //    new Calisan { Id = 2, Name = "Hülya Akın", SalonId = 2, Position = "Manikürist", ExperienceYears = 3 },
            //    new Calisan { Id = 3, Name = "Burak Şen", SalonId = 3, Position = "Pedikürist", ExperienceYears = 4 },
            //    new Calisan { Id = 4, Name = "Elif Güneş", SalonId = 4, Position = "Cilt Bakım Uzmanı", ExperienceYears = 6 },
            //    new Calisan { Id = 5, Name = "Selim Kaya", SalonId = 5, Position = "Saç Stilisti", ExperienceYears = 7 }
            //);

            //// Çalışma Saatleri
            //modelBuilder.Entity<CalismaSaati>().HasData(
            //    new CalismaSaati { Id = 1, CalisanId = 1, DayOfWeek = "Pazartesi", StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(18, 0, 0) },
            //    new CalismaSaati { Id = 2, CalisanId = 2, DayOfWeek = "Salı", StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(19, 0, 0) },
            //    new CalismaSaati { Id = 3, CalisanId = 3, DayOfWeek = "Çarşamba", StartTime = new TimeSpan(8, 30, 0), EndTime = new TimeSpan(17, 30, 0) },
            //    new CalismaSaati { Id = 4, CalisanId = 4, DayOfWeek = "Perşembe", StartTime = new TimeSpan(9, 30, 0), EndTime = new TimeSpan(18, 30, 0) },
            //    new CalismaSaati { Id = 5, CalisanId = 5, DayOfWeek = "Cuma", StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(20, 0, 0) }
            //);

            //// Randevular
            //modelBuilder.Entity<Randevu>().HasData(
            //    new Randevu { Id = 1, UserId = 1, SalonId = 1, AppointmentTime = new DateTime(2024, 12, 13, 14, 0, 0), Service = "Saç Kesimi", Price = 50 },
            //    new Randevu { Id = 2, UserId = 2, SalonId = 2, AppointmentTime = new DateTime(2024, 12, 14, 15, 0, 0), Service = "Manikür", Price = 80 },
            //    new Randevu { Id = 3, UserId = 3, SalonId = 3, AppointmentTime = new DateTime(2024, 12, 15, 16, 0, 0), Service = "Pedikür", Price = 100 },
            //    new Randevu { Id = 4, UserId = 4, SalonId = 4, AppointmentTime = new DateTime(2024, 12, 16, 11, 0, 0), Service = "Cilt Bakımı", Price = 150 },
            //    new Randevu { Id = 5, UserId = 5, SalonId = 5, AppointmentTime = new DateTime(2024, 12, 17, 13, 0, 0), Service = "Saç Boyama", Price = 200 }
            //);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=BERBERshop;Trusted_Connection=True;");
        }
    }
}
