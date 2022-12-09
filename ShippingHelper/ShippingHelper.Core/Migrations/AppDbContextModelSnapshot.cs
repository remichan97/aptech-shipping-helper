﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShippingHelper.Core.Data;

#nullable disable

namespace ShippingHelper.Core.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
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
                            ConcurrencyStamp = "1a8b51cb-2953-414b-afad-e270460eeb0d",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "433bef6f-10d9-44f3-9193-28a8bfa35c5c",
                            ConcurrencyStamp = "136d9722-be52-45a2-be06-b4b38e573593",
                            Name = "Shipping Merchant",
                            NormalizedName = "SHIPPING MERCHANT"
                        },
                        new
                        {
                            Id = "d51059b9-ca3b-4fdd-ad1e-23b9e4956686",
                            ConcurrencyStamp = "c9583bcb-690b-4aa2-9613-f97428af6600",
                            Name = "Shop Merchant",
                            NormalizedName = "SHOP MERCHANT"
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

            modelBuilder.Entity("ShippingHelper.Core.Models.Cities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hồ Chí Minh"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Hà Nội"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Đà Nẵng"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Bình Dương"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Đồng Nai"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Khánh Hòa"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Hải Phòng"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Long An"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Quảng Nam"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Bà Rịa Vũng Tàu"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Đắk Lắk"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Cần Thơ"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Bình Thuận"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Lâm Đồng"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Thừa Thiên Huế"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Kiên Giang"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Bắc Ninh"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Quảng Ninh"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Thanh Hóa"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Nghệ An"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Hải Dương"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Gia Lai"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Bình Phước"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Hưng Yên"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Bình Định"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Tiền Giang"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Thái Bình"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Bắc Giang"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Hòa Bình"
                        },
                        new
                        {
                            Id = 30,
                            Name = "An Giang"
                        },
                        new
                        {
                            Id = 31,
                            Name = "Vĩnh Phúc"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Tây Ninh"
                        },
                        new
                        {
                            Id = 33,
                            Name = "Thái Nguyên"
                        },
                        new
                        {
                            Id = 34,
                            Name = "Lào Cai"
                        },
                        new
                        {
                            Id = 35,
                            Name = "Nam Định"
                        },
                        new
                        {
                            Id = 36,
                            Name = "Quảng Ngãi"
                        },
                        new
                        {
                            Id = 37,
                            Name = "Bến Tre"
                        },
                        new
                        {
                            Id = 38,
                            Name = "Đắk Nông"
                        },
                        new
                        {
                            Id = 39,
                            Name = "Cà Mau"
                        },
                        new
                        {
                            Id = 40,
                            Name = "Vĩnh Long"
                        },
                        new
                        {
                            Id = 41,
                            Name = "Ninh Bình"
                        },
                        new
                        {
                            Id = 42,
                            Name = "Phú Thọ"
                        },
                        new
                        {
                            Id = 43,
                            Name = "Ninh Thuận"
                        },
                        new
                        {
                            Id = 44,
                            Name = "Phú Yên"
                        },
                        new
                        {
                            Id = 45,
                            Name = "Hà Nam"
                        },
                        new
                        {
                            Id = 46,
                            Name = "Hà Tĩnh"
                        },
                        new
                        {
                            Id = 47,
                            Name = "Đồng Tháp"
                        },
                        new
                        {
                            Id = 48,
                            Name = "Sóc Trăng"
                        },
                        new
                        {
                            Id = 49,
                            Name = "Kon Tum"
                        },
                        new
                        {
                            Id = 50,
                            Name = "Quảng Bình"
                        },
                        new
                        {
                            Id = 51,
                            Name = "Quảng Trị"
                        },
                        new
                        {
                            Id = 52,
                            Name = "Trà Vinh"
                        },
                        new
                        {
                            Id = 53,
                            Name = "Hậu Giang"
                        },
                        new
                        {
                            Id = 54,
                            Name = "Sơn La"
                        },
                        new
                        {
                            Id = 55,
                            Name = "Bạc Liêu"
                        },
                        new
                        {
                            Id = 56,
                            Name = "Yên Bái"
                        },
                        new
                        {
                            Id = 57,
                            Name = "Tuyên Quang"
                        },
                        new
                        {
                            Id = 58,
                            Name = "Điện Biên"
                        },
                        new
                        {
                            Id = 59,
                            Name = "Lai Châu"
                        },
                        new
                        {
                            Id = 60,
                            Name = "Lạng Sơn"
                        },
                        new
                        {
                            Id = 61,
                            Name = "Hà Giang"
                        },
                        new
                        {
                            Id = 62,
                            Name = "Bắc Kạn"
                        },
                        new
                        {
                            Id = 63,
                            Name = "Cao Bằng"
                        });
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

                    b.Property<string>("Subjects")
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

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CompletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EndAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostedDate")
                        .HasColumnType("datetime2");

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

                    b.HasIndex("CityId");

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

                    b.Property<Guid>("OfferId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfferId")
                        .IsUnique();

                    b.ToTable("ProductOffers");
                });

            modelBuilder.Entity("ShippingHelper.Core.Models.ReportedMerchant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReportType")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ReportedMerchants");
                });

            modelBuilder.Entity("ShippingHelper.Core.Models.Users", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDisabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("CityId");

                    b.HasDiscriminator().HasValue("Users");

                    b.HasData(
                        new
                        {
                            Id = "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9049ec6e-3614-4d84-89ff-5226fb607d35",
                            Email = "admin@shiplink.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@SHPLINK.COM",
                            NormalizedUserName = "ADMIN@SHIPLINK.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBonS32f0tv5B1l9k4XJAXJbYaPHO9zeSyeq4H3GmJz0Dc8ABkSWKGdbq0BM3Cj66A==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "59512c64-02bf-4767-a1a7-e71dd927be64",
                            TwoFactorEnabled = false,
                            UserName = "admin@shiplink.com",
                            Address = "Admin",
                            CityId = 1,
                            FirstName = "System",
                            IsDisabled = false,
                            LastName = "Admin"
                        },
                        new
                        {
                            Id = "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ed145e48-9e8a-45a6-bade-7f25e8f654fa",
                            Email = "shipper@shiplink.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "SHIPPER@SHPLINK.COM",
                            NormalizedUserName = "SHIPPER@SHIPLINK.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIspqCuwvf08xbfWMDTUTN2teCvVsaYNHdaXxEmGx+Ccj0WRt3FPW1k4tKkDnUpq4Q==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ab8d99dc-295c-4377-a88a-0a200ef96e93",
                            TwoFactorEnabled = false,
                            UserName = "shipper@shiplink.com",
                            Address = "Shipping",
                            CityId = 2,
                            FirstName = "Demo",
                            IsDisabled = false,
                            LastName = "Shipper"
                        },
                        new
                        {
                            Id = "99ba2b16-99c6-41e5-b6be-7401c6896d02",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0eb848cf-376c-4727-9b85-6433f4b954bf",
                            Email = "shop@shiplink.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "SHOP@SHPLINK.COM",
                            NormalizedUserName = "SHOP@SHIPLINK.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENlOlFxYGE3ax6HUf2LfVsSy67eFO4WoXwPdI6nRI45tOFDgt7io6kh5SDZcNdIXzQ==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "264b8c85-58be-47b1-9d72-3cc0bbf18b7c",
                            TwoFactorEnabled = false,
                            UserName = "shop@shiplink.com",
                            Address = "189 Thanh Nhan, Hai Ba Trung",
                            CityId = 2,
                            FirstName = "Demo",
                            IsDisabled = false,
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
                    b.HasOne("ShippingHelper.Core.Models.Cities", "Cities")
                        .WithMany("Offers")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShippingHelper.Core.Models.Users", "Users")
                        .WithMany("Offers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cities");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ShippingHelper.Core.Models.ProductOffers", b =>
                {
                    b.HasOne("ShippingHelper.Core.Models.Offers", "Offers")
                        .WithOne("ProductOffers")
                        .HasForeignKey("ShippingHelper.Core.Models.ProductOffers", "OfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Offers");
                });

            modelBuilder.Entity("ShippingHelper.Core.Models.ReportedMerchant", b =>
                {
                    b.HasOne("ShippingHelper.Core.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ShippingHelper.Core.Models.Users", b =>
                {
                    b.HasOne("ShippingHelper.Core.Models.Cities", "Cities")
                        .WithMany("Users")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cities");
                });

            modelBuilder.Entity("ShippingHelper.Core.Models.Cities", b =>
                {
                    b.Navigation("Offers");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ShippingHelper.Core.Models.Offers", b =>
                {
                    b.Navigation("ProductOffers")
                        .IsRequired();
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
