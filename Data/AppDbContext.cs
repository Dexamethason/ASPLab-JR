using Data.Models;
using Data.Models.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class AppDbContext : IdentityDbContext<IdentityUser>
{
	public AppDbContext()
	{
		var folder = Environment.SpecialFolder.LocalApplicationData;
		var path = Environment.GetFolderPath(folder);
		DbPath = Path.Join(path, "photos.db");
	}

	public DbSet<PhotoEntity> Photos { get; set; }
	public DbSet<AuthorEntity> Authors { get; set; }
	public DbSet<AddressEntity> Address { get; set; }

	private string DbPath { get; }

	protected override void OnConfiguring(DbContextOptionsBuilder options)
	{
		options.UseSqlite($"Data Source={DbPath}");
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		var ADMIN_ID = Guid.NewGuid().ToString();
		var ADMIN_ROLE_ID = Guid.NewGuid().ToString();

		var USER_ID = Guid.NewGuid().ToString();
		var USER_ROLE_ID = Guid.NewGuid().ToString();

		modelBuilder.Entity<IdentityRole>().HasData(
			new IdentityRole
			{
				Name = "admin",
				NormalizedName = "ADMIN",
				Id = ADMIN_ROLE_ID,
				ConcurrencyStamp = ADMIN_ROLE_ID
			});

		modelBuilder.Entity<IdentityRole>().HasData(
			new IdentityRole
			{
				Name = "user",
				NormalizedName = "USER",
				Id = USER_ROLE_ID,
				ConcurrencyStamp = USER_ROLE_ID
			});

		var admin = new IdentityUser
		{
			Id = ADMIN_ID,
			Email = "admin@gmail.com",
			NormalizedEmail = "ADMIN@GMAIL.COM",
			EmailConfirmed = true,
			UserName = "admin",
			NormalizedUserName = "ADMIN"
		};

		var user = new IdentityUser
		{
			Id = USER_ID,
			Email = "user@gmail.com",
			NormalizedEmail = "USER@GMAIL.COM",
			EmailConfirmed = true,
			UserName = "user",
			NormalizedUserName = "USER"
		};

		var ph = new PasswordHasher<IdentityUser>();

		admin.PasswordHash = ph.HashPassword(admin, "admin");
		user.PasswordHash = ph.HashPassword(user, "user");

		modelBuilder.Entity<IdentityUser>().HasData(admin);
		modelBuilder.Entity<IdentityUser>().HasData(user);

		modelBuilder.Entity<IdentityUserRole<string>>().HasData(
			new IdentityUserRole<string>
			{
				RoleId = ADMIN_ROLE_ID,
				UserId = ADMIN_ID
			});

		modelBuilder.Entity<IdentityUserRole<string>>().HasData(
			new IdentityUserRole<string>
			{
				RoleId = USER_ROLE_ID,
				UserId = USER_ID
			});

		modelBuilder.Entity<AddressEntity>().HasData(
			new AddressEntity
			{
				id = 1,
				Street = "123 Main Street",
				HouseNumber = "Apt 101",
				PostalCode = "12-345",
				City = "Anytown",
				Country = (CountryEnum)1,
				AuthorId = 7
			},
			new AddressEntity
			{
				id = 2,
				Street = "456 Elm Street",
				HouseNumber = "Unit 202",
				PostalCode = "67-890",
				City = "Othertown",
				Country = (CountryEnum)2,
				AuthorId = 6
			},
			new AddressEntity
			{
				id = 3,
				Street = "789 Oak Avenue",
				HouseNumber = "Suite 303",
				PostalCode = "AB-CDE",
				City = "Somewhere",
				Country = (CountryEnum)3,
				AuthorId = 5
			},
			new AddressEntity
			{
				id = 4,
				Street = "321 Pine Lane",
				HouseNumber = "Unit 404",
				PostalCode = "WX-YZA",
				City = "Anothercity",
				Country = (CountryEnum)4,
				AuthorId = 4
			},
			new AddressEntity
			{
				id = 5,
				Street = "555 Cedar Street",
				HouseNumber = "Apt 505",
				PostalCode = "54-321",
				City = "Yetanothercity",
				Country = (CountryEnum)5,
				AuthorId = 3
			},
			new AddressEntity
			{
				id = 6,
				Street = "777 Maple Avenue",
				HouseNumber = "Suite 606",
				PostalCode = "FG-HIJ",
				City = "Anotherplace",
				Country = (CountryEnum)6,
				AuthorId = 2
			},
			new AddressEntity
			{
				id = 7,
				Street = "999 Birch Road",
				HouseNumber = "Unit 707",
				PostalCode = "LM-NOP",
				City = "Someplace",
				Country = (CountryEnum)7,
				AuthorId = 1
			},
			new AddressEntity
			{
				id = 8,
				Street = "111 Oak Street",
				HouseNumber = "Apartment 808",
				PostalCode = "QR-STU",
				City = "Yetanotherplace",
				Country = (CountryEnum)8,
				AuthorId = 1
			}
		);

		modelBuilder.Entity<AuthorEntity>().HasData(
			new AuthorEntity
			{
				Id = 1,
				FirstName = "John",
				Surname = "Doe"
			},
			new AuthorEntity
			{
				Id = 2,
				FirstName = "Jane",
				Surname = "Smith"
			},
			new AuthorEntity
			{
				Id = 3,
				FirstName = "Michael",
				Surname = "Johnson"
			},
			new AuthorEntity
			{
				Id = 4,
				FirstName = "Emily",
				Surname = "Brown"
			},
			new AuthorEntity
			{
				Id = 5,
				FirstName = "David",
				Surname = "Williams"
			},
			new AuthorEntity
			{
				Id = 6,
				FirstName = "Sarah",
				Surname = "Jones"
			},
			new AuthorEntity
			{
				Id = 7,
				FirstName = "Daniel",
				Surname = "Garcia"
			},
			new AuthorEntity
			{
				Id = 8,
				FirstName = "Jessica",
				Surname = "Martinez"
			},
			new AuthorEntity
			{
				Id = 9,
				FirstName = "James",
				Surname = "Lee"
			},
			new AuthorEntity
			{
				Id = 10,
				FirstName = "Sophia",
				Surname = "Lopez"
			}
		);

		modelBuilder.Entity<PhotoEntity>().HasData(
			new PhotoEntity
			{
				Id = 1,
				DateTimeTaken = new DateTime(2023, 5, 15, 13, 30, 0),
				Description = "Beautiful landscape",
				Camera = "Canon EOS 5D Mark IV",
				AuthorEmail = "john.doe@example.com",
				Resolution = "6000x4000",
				Format = ".png",
				AuthorId = 1
			},
			new PhotoEntity
			{
				Id = 2,
				DateTimeTaken = new DateTime(2023, 6, 20, 10, 15, 0),
				Description = "Sunset on the beach",
				Camera = "Nikon D850",
				AuthorEmail = "jane.smith@example.com",
				Resolution = "8256x5504",
				Format = ".png",
				AuthorId = 2
			},
			new PhotoEntity
			{
				Id = 3,
				DateTimeTaken = new DateTime(2023, 7, 10, 9, 45, 0),
				Description = "Urban cityscape",
				Camera = "Sony Alpha a7 III",
				AuthorEmail = "michael.johnson@example.com",
				Resolution = "6000x3376",
				Format = ".png",
				AuthorId = 3
			},
			new PhotoEntity
			{
				Id = 6,
				DateTimeTaken = new DateTime(2023, 8, 5, 14, 0, 0),
				Description = "Mountain peak",
				Camera = "Fujifilm X-T4",
				AuthorEmail = "emily.brown@example.com",
				Resolution = "6240x4160",
				Format = ".jpg",
				AuthorId = 4
			},
			new PhotoEntity
			{
				Id = 7,
				DateTimeTaken = new DateTime(2023, 9, 12, 12, 30, 0),
				Description = "Historic landmark",
				Camera = "Leica Q2",
				AuthorEmail = "david.williams@example.com",
				Resolution = "8368x5584",
				Format = ".jpg",
				AuthorId = 5
			},
			new PhotoEntity
			{
				Id = 8,
				DateTimeTaken = new DateTime(2023, 10, 25, 11, 0, 0),
				Description = "Colorful street art",
				Camera = "Panasonic Lumix S5",
				AuthorEmail = "sarah.jones@example.com",
				Resolution = "6000x4000",
				Format = ".jpg",
				AuthorId = 6
			},
			new PhotoEntity
			{
				Id = 9,
				DateTimeTaken = new DateTime(2023, 11, 8, 16, 45, 0),
				Description = "Spectacular waterfall",
				Camera = "Olympus OM-D E-M1 Mark III",
				AuthorEmail = "daniel.garcia@example.com",
				Resolution = "5184x3888",
				Format = ".jpg",
				AuthorId = 7
			},
			new PhotoEntity
			{
				Id = 10,
				DateTimeTaken = new DateTime(2023, 12, 20, 9, 15, 0),
				Description = "Winter wonderland",
				Camera = "Pentax K-1 Mark II",
				AuthorEmail = "jessica.martinez@example.com",
				Resolution = "7360x4912",
				Format = ".jpg",
				AuthorId = 8
			}
		);
	}
}