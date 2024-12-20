                                                                                                                                                                                    using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmithSwimmingSchool_NickMorales.Models;

namespace SmithSwimmingSchool_NickMorales.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Swimmer> Swimmers { get; set; }
        public DbSet<Coach> Coachs { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Coaches
            modelBuilder.Entity<Coach>().HasData(
                new Coach { CoachID = 1, Name = "Alejandro García", PhoneNumber = "123456780", Email = "alejandro.garcia@gmail.com" },
                new Coach { CoachID = 2, Name = "Mariana López", PhoneNumber = "123456781", Email = "mariana.lopez@gmail.com" }
            );

            // Seed Swimmers
            modelBuilder.Entity<Swimmer>().HasData(
                new Swimmer { SwimmerID = 1, Name = "Juan Pérez", PhoneNumber = "111111111", Email = "juan.perez@gmail.com", Genre = Genre.Male, BirthDate = DateTime.Parse("2005-09-01") },
                new Swimmer { SwimmerID = 2, Name = "Laura Martínez", PhoneNumber = "222222222", Email = "laura.martinez@gmail.com", Genre = Genre.Female, BirthDate = DateTime.Parse("2010-09-01") },
                new Swimmer { SwimmerID = 3, Name = "Sofía Torres", PhoneNumber = "333333333", Email = "sofia.torres@gmail.com", Genre = Genre.Female, BirthDate = DateTime.Parse("2008-09-01") },
                new Swimmer { SwimmerID = 4, Name = "Gonzalo Torres", PhoneNumber = "333333333", Email = "gonzalo.torres@gmail.com", Genre = Genre.Male, BirthDate = DateTime.Parse("2008-09-01") }
            );

            // Seed Courses
            modelBuilder.Entity<Course>().HasData(
                new Course { CourseID = 1, Title = "Advanced Youth", CoachID = 1 },
                new Course { CourseID = 2, Title = "Beginner Adults", CoachID = 2 }
            );

            // Seed Groups
            modelBuilder.Entity<Group>().HasData(
                new Group { GroupID = 1, Level = Level.Advanced, StartDate = DateTime.Parse("2023-01-01"), EndDate = DateTime.Parse("2023-12-31"), Places = 20 },
                new Group { GroupID = 2, Level = Level.Beginner, StartDate = DateTime.Parse("2023-01-01"), EndDate = DateTime.Parse("2023-12-31"), Places = 20 }
            );

            // Seed Enrollments
            modelBuilder.Entity<Enrollment>().HasData(
                new Enrollment { EnrollmentID = 1, CourseID = 1, SwimmerID = 1, GroupID = 1 },
                new Enrollment { EnrollmentID = 2, CourseID = 2, SwimmerID = 2, GroupID = 2 },
                new Enrollment { EnrollmentID = 3, CourseID = 2, SwimmerID = 3, GroupID = 2 }
            );

            // Seed Reports
            modelBuilder.Entity<Report>().HasData(
                new Report { ReportID = 1, Description = "Excellent progress", EnrollmentID = 1 },
                new Report { ReportID = 2, Description = "Needs improvement in technique", EnrollmentID = 2 }
            );

            //Seed Roles
            List<IdentityRole> roles = new List<IdentityRole>()
            {
                new IdentityRole {Name = "Administrator", NormalizedName = "ADMINISTRATOR"},
                new IdentityRole {Name = "Swimmer", NormalizedName = "SWIMMER"},
                new IdentityRole {Name = "Coach", NormalizedName ="COACH"},
                new IdentityRole {Name = "Visitor", NormalizedName ="VISITOR"}
            };
            modelBuilder.Entity<IdentityRole>().HasData(roles);

            //Seed Users 
            List<IdentityUser> users = new List<IdentityUser>()
            {
                new IdentityUser {UserName ="admin@gmail.com", NormalizedUserName="ADMIN@GMAIL.COM", NormalizedEmail = "ADMIN@GMAIL.COM", Email = "admin@gmail.com", EmailConfirmed= true },
                new IdentityUser {UserName ="visitor@gmail.com", NormalizedUserName="VISITOR@GMAIL.COM", NormalizedEmail = "VISITOR@GMAIL.COM", Email = "visitor@gmail.com", EmailConfirmed= true },
                new IdentityUser {UserName ="alejandro.garcia@gmail.com", NormalizedUserName="ALEJANDRO.GARCIA@GMAIL.COM", NormalizedEmail = "ALEJANDRO.GARCIA@GMAIL.COM", Email = "alejandro.garcia@gmail.com", EmailConfirmed= true},
                new IdentityUser {UserName ="mariana.lopez@gmail.com", NormalizedUserName="MARIANA.LOPEZ@GMAIL.COM",  NormalizedEmail = "MARIANA.LOPEZ@GMAIL.COM", Email = "mariana.lopez@gmail.com", EmailConfirmed= true},
                new IdentityUser {UserName ="juan.perez@gmail.com", NormalizedUserName="JUAN.PEREZ@GMAIL.COM", NormalizedEmail = "JUAN.PEREZ@GMAIL.COM", Email = "juan.perez@gmail.com", EmailConfirmed = true},
                new IdentityUser {UserName ="laura.martinez@gmail.com", NormalizedUserName="LAURA.MARTINEZ@GMAIL.COM", NormalizedEmail = "LAURA.MARTINEZ@GMAIL.COM", Email = "laura.martinez@gmail.com" , EmailConfirmed = true},
                new IdentityUser {UserName ="sofia.torres@gmail.com", NormalizedUserName="SOFIA.TORRES@GMAIL.COM", NormalizedEmail = "SOFIA.TORRES@GMAIL.COM", Email = "sofia.torres@gmail.com", EmailConfirmed = true},
                new IdentityUser {UserName ="gonzalo.torres@gmail.com", NormalizedUserName="GONZALO.TORRES@GMAIL.COM", NormalizedEmail = "GONZALO.TORRES@GMAIL.COM", Email = "gonzalo.torres@gmail.com", EmailConfirmed = true},
            };

            var passwordHasher = new PasswordHasher<IdentityUser>();
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "Password123!");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "Password123!");
            users[2].PasswordHash = passwordHasher.HashPassword(users[2], "Password123!");
            users[3].PasswordHash = passwordHasher.HashPassword(users[3], "Password123!");
            users[4].PasswordHash = passwordHasher.HashPassword(users[4], "Password123!");
            users[5].PasswordHash = passwordHasher.HashPassword(users[5], "Password123!");
            users[6].PasswordHash = passwordHasher.HashPassword(users[6], "Password123!");
            users[7].PasswordHash = passwordHasher.HashPassword(users[6], "Password123!");

            modelBuilder.Entity<IdentityUser>().HasData(users);

            //Seed add role to user

            List <IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[0].Id,
                RoleId = roles.First(q => q.Name == "Administrator").Id
            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[1].Id,
                RoleId = roles.First(q => q.Name == "Visitor").Id
            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[2].Id,
                RoleId = roles.First(q => q.Name == "Coach").Id
            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[3].Id,
                RoleId = roles.First(q => q.Name == "Coach").Id
            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[4].Id,
                RoleId = roles.First(q => q.Name == "Swimmer").Id
            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[5].Id,
                RoleId = roles.First(q => q.Name == "Swimmer").Id
            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[6].Id,
                RoleId = roles.First(q => q.Name == "Swimmer").Id
            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[7].Id,
                RoleId = roles.First(q => q.Name == "Swimmer").Id
            });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
    }
}
