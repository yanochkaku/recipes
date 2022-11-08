﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recipes.Core;

#nullable disable

namespace Recipes.Core.Migrations
{
    [DbContext(typeof(RecipesContext))]
<<<<<<< Updated upstream:Recipes/Recipes.Core/Migrations/20221106182347_Init1.Designer.cs
    [Migration("20221106182347_Init1")]
    partial class Init1
=======
    [Migration("20221108091710_Init2")]
    partial class Init2
>>>>>>> Stashed changes:Recipes/Recipes.Core/Migrations/20221108091710_Init2.Designer.cs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
<<<<<<< Updated upstream:Recipes/Recipes.Core/Migrations/20221106182347_Init1.Designer.cs
                            Id = "9f138bb5-2f5d-4919-a8f5-a26007d84eee",
                            ConcurrencyStamp = "a2000922-b777-4917-b048-533d3ee55d37",
=======
                            Id = "f2db02f7-1fb7-45fa-8929-8a13002ad5b6",
                            ConcurrencyStamp = "e0fd0926-b19f-432e-9475-55340757debf",
>>>>>>> Stashed changes:Recipes/Recipes.Core/Migrations/20221108091710_Init2.Designer.cs
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
<<<<<<< Updated upstream:Recipes/Recipes.Core/Migrations/20221106182347_Init1.Designer.cs
                            Id = "17f1efb3-c24d-41f9-a1b3-46f4508cda42",
                            ConcurrencyStamp = "667f5fc2-c4f8-445b-af81-c9840d368a64",
=======
                            Id = "5b994991-8ebe-4455-8ec6-6153ead77c98",
                            ConcurrencyStamp = "e69f0e04-d50d-4edf-81b5-222e92b81d00",
>>>>>>> Stashed changes:Recipes/Recipes.Core/Migrations/20221108091710_Init2.Designer.cs
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
<<<<<<< Updated upstream:Recipes/Recipes.Core/Migrations/20221106182347_Init1.Designer.cs
                            Id = "640a86e2-28ba-4b46-ac08-313fa07a1af3",
                            ConcurrencyStamp = "e2b582b4-0577-47b3-b806-c4650e70c545",
=======
                            Id = "049a4302-e700-42a6-a940-50ac34d3119e",
                            ConcurrencyStamp = "c3cb07b0-d870-4717-a24c-e39cc96f59de",
>>>>>>> Stashed changes:Recipes/Recipes.Core/Migrations/20221108091710_Init2.Designer.cs
                            Name = "User",
                            NormalizedName = "USER"
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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
<<<<<<< Updated upstream:Recipes/Recipes.Core/Migrations/20221106182347_Init1.Designer.cs
                            UserId = "7a512027-4a1b-4973-a06f-34fbf92b29d8",
                            RoleId = "9f138bb5-2f5d-4919-a8f5-a26007d84eee"
                        },
                        new
                        {
                            UserId = "7a512027-4a1b-4973-a06f-34fbf92b29d8",
                            RoleId = "17f1efb3-c24d-41f9-a1b3-46f4508cda42"
                        },
                        new
                        {
                            UserId = "7a512027-4a1b-4973-a06f-34fbf92b29d8",
                            RoleId = "640a86e2-28ba-4b46-ac08-313fa07a1af3"
                        },
                        new
                        {
                            UserId = "fdac4d46-e51a-47b3-92e9-ee272eaa1451",
                            RoleId = "17f1efb3-c24d-41f9-a1b3-46f4508cda42"
                        },
                        new
                        {
                            UserId = "fdac4d46-e51a-47b3-92e9-ee272eaa1451",
                            RoleId = "640a86e2-28ba-4b46-ac08-313fa07a1af3"
                        },
                        new
                        {
                            UserId = "5db8c868-2c51-4928-b263-d04de8eeab4e",
                            RoleId = "640a86e2-28ba-4b46-ac08-313fa07a1af3"
=======
                            UserId = "77eee32a-53c3-4b24-b14b-ef0d2fb92397",
                            RoleId = "f2db02f7-1fb7-45fa-8929-8a13002ad5b6"
                        },
                        new
                        {
                            UserId = "77eee32a-53c3-4b24-b14b-ef0d2fb92397",
                            RoleId = "5b994991-8ebe-4455-8ec6-6153ead77c98"
                        },
                        new
                        {
                            UserId = "77eee32a-53c3-4b24-b14b-ef0d2fb92397",
                            RoleId = "049a4302-e700-42a6-a940-50ac34d3119e"
                        },
                        new
                        {
                            UserId = "0d999b5d-bd65-44e3-85a8-f600c38196f9",
                            RoleId = "5b994991-8ebe-4455-8ec6-6153ead77c98"
                        },
                        new
                        {
                            UserId = "0d999b5d-bd65-44e3-85a8-f600c38196f9",
                            RoleId = "049a4302-e700-42a6-a940-50ac34d3119e"
                        },
                        new
                        {
                            UserId = "e9a8c52e-1985-470a-a144-8a706acf4b54",
                            RoleId = "049a4302-e700-42a6-a940-50ac34d3119e"
>>>>>>> Stashed changes:Recipes/Recipes.Core/Migrations/20221108091710_Init2.Designer.cs
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Recipes.Core.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NameCategory")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Recipes.Core.InfoDish", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int?>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<string>("CookingTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Difficulty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preparation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriesId");

                    b.ToTable("InfoDishes");
                });

            modelBuilder.Entity("Recipes.Core.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

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

                    b.HasData(
                        new
                        {
<<<<<<< Updated upstream:Recipes/Recipes.Core/Migrations/20221106182347_Init1.Designer.cs
                            Id = "7a512027-4a1b-4973-a06f-34fbf92b29d8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4dc29f15-5001-40d8-a0be-d8d2fac19209",
=======
                            Id = "77eee32a-53c3-4b24-b14b-ef0d2fb92397",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0a5a5f5a-f8d6-4388-84ea-a8dba03cf3b0",
>>>>>>> Stashed changes:Recipes/Recipes.Core/Migrations/20221108091710_Init2.Designer.cs
                            Email = "admin@recipes.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@RECIPES.COM",
                            NormalizedUserName = "ADMIN@RECIPES.COM",
<<<<<<< Updated upstream:Recipes/Recipes.Core/Migrations/20221106182347_Init1.Designer.cs
                            PasswordHash = "AQAAAAEAACcQAAAAEGXHKQgdOFS54kTZwatsNwLc1izLPo891sew7SR0Asrd8PQz3FslEGuerLXFTXR+NA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "150518a4-63c3-4b63-999b-96eff6f93a5f",
=======
                            PasswordHash = "AQAAAAEAACcQAAAAEFg4xmKNneu17R8r5jraUM+V5/xeMjK3XVxfjAH5aFDFd+QtXjEgdeXg0L3ecLFeag==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "66de81e8-9049-4fc7-af49-ae914960752b",
>>>>>>> Stashed changes:Recipes/Recipes.Core/Migrations/20221108091710_Init2.Designer.cs
                            TwoFactorEnabled = false,
                            UserName = "admin@recipes.com"
                        },
                        new
                        {
<<<<<<< Updated upstream:Recipes/Recipes.Core/Migrations/20221106182347_Init1.Designer.cs
                            Id = "fdac4d46-e51a-47b3-92e9-ee272eaa1451",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "18f942f8-1ab3-4de4-a570-19b39ae004bf",
=======
                            Id = "0d999b5d-bd65-44e3-85a8-f600c38196f9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a436e9eb-431d-490b-812e-5519cc4f3128",
>>>>>>> Stashed changes:Recipes/Recipes.Core/Migrations/20221108091710_Init2.Designer.cs
                            Email = "manager@recipes.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MANAGER@RECIPES.COM",
                            NormalizedUserName = "MANAGER@RECIPES.COM",
<<<<<<< Updated upstream:Recipes/Recipes.Core/Migrations/20221106182347_Init1.Designer.cs
                            PasswordHash = "AQAAAAEAACcQAAAAEE3zYRoiQeCdp4jJwA0qM5Y8H35b3DXrA/K/2brHm96tftFK00R+t5oHM+PEfHL9DQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f636ff43-a734-44f7-b417-e5549d8da110",
=======
                            PasswordHash = "AQAAAAEAACcQAAAAEMJx6Lz++IE+FYgFM7ZRJR1Aw/oz4EcnTl8NRdZDpL56xTiVcZsxbWpTitHN2c7ruQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5061513f-6fd1-4f04-83ff-3a0efe6bd11c",
>>>>>>> Stashed changes:Recipes/Recipes.Core/Migrations/20221108091710_Init2.Designer.cs
                            TwoFactorEnabled = false,
                            UserName = "manager@recipes.com"
                        },
                        new
                        {
<<<<<<< Updated upstream:Recipes/Recipes.Core/Migrations/20221106182347_Init1.Designer.cs
                            Id = "5db8c868-2c51-4928-b263-d04de8eeab4e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "731d192e-c90f-4a9c-b2ec-2855a6480db8",
=======
                            Id = "e9a8c52e-1985-470a-a144-8a706acf4b54",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a2451a92-02c7-454a-9a11-6bbc12427960",
>>>>>>> Stashed changes:Recipes/Recipes.Core/Migrations/20221108091710_Init2.Designer.cs
                            Email = "user@recipes.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@RECIPES.COM",
                            NormalizedUserName = "USER@RECIPES.COM",
<<<<<<< Updated upstream:Recipes/Recipes.Core/Migrations/20221106182347_Init1.Designer.cs
                            PasswordHash = "AQAAAAEAACcQAAAAEOpXX0bPnu/SEoHNDlG999lCbLn8Tv1IiBweFGeELO9AE11HyWemk6UdifDDyzdteg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "93a8e3a1-7966-4006-b9cf-1f2b0d56e740",
=======
                            PasswordHash = "AQAAAAEAACcQAAAAEFq/8dCZ45QEPcGbkqBTaOvsVC0VR+dIC8FxtWubdeCQmZfHh4cyRPaJv7ShgZNf9w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6f1eebd4-5b31-4154-a1da-e5adeefeb739",
>>>>>>> Stashed changes:Recipes/Recipes.Core/Migrations/20221108091710_Init2.Designer.cs
                            TwoFactorEnabled = false,
                            UserName = "user@recipes.com"
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
                    b.HasOne("Recipes.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Recipes.Core.User", null)
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

                    b.HasOne("Recipes.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Recipes.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Recipes.Core.InfoDish", b =>
                {
                    b.HasOne("Recipes.Core.Category", "Categories")
                        .WithMany("infoDish")
                        .HasForeignKey("CategoriesId");

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("Recipes.Core.Category", b =>
                {
                    b.Navigation("infoDish");
                });
#pragma warning restore 612, 618
        }
    }
}
