// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShippingHelper.Core.Data;

#nullable disable

namespace ShippingHelper.Core.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221016045446_InitDb")]
    partial class InitDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "40f71694-8d9d-4c9e-9698-4ebaad596253",
                            ConcurrencyStamp = "bb4e2db8-8408-429b-9427-e1a0ece6d767",
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = "433bef6f-10d9-44f3-9193-28a8bfa35c5c",
                            ConcurrencyStamp = "479b252e-afcb-4746-95d5-6feeb98ff9eb",
                            Name = "Shipping Merchant"
                        },
                        new
                        {
                            Id = "d51059b9-ca3b-4fdd-ad1e-23b9e4956686",
                            ConcurrencyStamp = "e9d7129b-920a-4025-8f6e-a08839fb2bc3",
                            Name = "Shop Merchant"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                            RoleId = "40f71694-8d9d-4c9e-9698-4ebaad596253"
                        },
                        new
                        {
                            UserId = "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                            RoleId = "433bef6f-10d9-44f3-9193-28a8bfa35c5c"
                        },
                        new
                        {
                            UserId = "99ba2b16-99c6-41e5-b6be-7401c6896d02",
                            RoleId = "d51059b9-ca3b-4fdd-ad1e-23b9e4956686"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ShippingHelper.Core.Models.AcceptOffers", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("OfferId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "OfferId");

                    b.HasIndex("OfferId");

                    b.ToTable("AcceptOffers");
                });

            modelBuilder.Entity("ShippingHelper.Core.Models.Contacts", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("ShippingHelper.Core.Models.Offers", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EndAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("StartAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("ShippingHelper.Core.Models.ProductOffers", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OffersId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OffersId");

                    b.ToTable("ProductOffers");
                });

            modelBuilder.Entity("ShippingHelper.Core.Models.Users", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Users");

                    b.HasData(
                        new
                        {
                            Id = "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1800a19b-4344-419b-8057-fd90daed84ea",
                            Email = "admin@shiplink.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@SHPLINK.COM",
                            NormalizedUserName = "ADMIN@SHIPLINK.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIHyfozTsMJG91qY1sVctyp0Cz54J95jNV7Gteyzan6CKvlxMDDaTsYcosNsNkwv7w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b4aba5d5-54b5-437b-afdd-c3b420b79bab",
                            TwoFactorEnabled = false,
                            UserName = "admin@shiplink.com",
                            Address = "Admin",
                            FirstName = "System",
                            LastName = "Admin"
                        },
                        new
                        {
                            Id = "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c7b82849-e91a-43da-b127-3ac815e7985c",
                            Email = "shipper@shiplink.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "SHIPPER@SHPLINK.COM",
                            NormalizedUserName = "SHIPPER@SHIPLINK.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENF03q96Vp0DFrmzt7JOPhFV4plj7wjEawyzCRcg/mgH+/0SCJppS0J6HbowQae7Ew==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e38ad011-b150-44a4-ad81-e283e05b20b4",
                            TwoFactorEnabled = false,
                            UserName = "shipper@shiplink.com",
                            Address = "Shipping",
                            FirstName = "Demo",
                            LastName = "Shipper"
                        },
                        new
                        {
                            Id = "99ba2b16-99c6-41e5-b6be-7401c6896d02",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7472087d-05c4-444c-8d42-4377baa248a7",
                            Email = "shop@shiplink.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "SHOP@SHPLINK.COM",
                            NormalizedUserName = "SHOP@SHIPLINK.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEK1zAUwH+aazMOaO5+RR2Mn+Q0jsTn8MOvLdB9ogofW7eAwaQbKqENgsGWMj/Cmk3Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "34de8ff5-f73f-42c5-b4ab-cd8a3f90dff2",
                            TwoFactorEnabled = false,
                            UserName = "shop@shiplink.com",
                            Address = "Shop Address",
                            FirstName = "Demo",
                            LastName = "Shop Merchant"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShippingHelper.Core.Models.AcceptOffers", b =>
                {
                    b.HasOne("ShippingHelper.Core.Models.Offers", "Offers")
                        .WithMany()
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShippingHelper.Core.Models.Users", "Users")
                        .WithMany("AcceptOffers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Offers");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ShippingHelper.Core.Models.Offers", b =>
                {
                    b.HasOne("ShippingHelper.Core.Models.Users", "Users")
                        .WithMany("Offers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ShippingHelper.Core.Models.ProductOffers", b =>
                {
                    b.HasOne("ShippingHelper.Core.Models.Offers", "Offers")
                        .WithMany("ProductOffers")
                        .HasForeignKey("OffersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Offers");
                });

            modelBuilder.Entity("ShippingHelper.Core.Models.Offers", b =>
                {
                    b.Navigation("ProductOffers");
                });

            modelBuilder.Entity("ShippingHelper.Core.Models.Users", b =>
                {
                    b.Navigation("AcceptOffers");

                    b.Navigation("Offers");
                });
#pragma warning restore 612, 618
        }
    }
}
