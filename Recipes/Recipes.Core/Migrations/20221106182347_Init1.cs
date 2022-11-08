﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recipes.Core.Migrations
{
    public partial class Init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCategory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InfoDishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Difficulty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CookingTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preparation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoDishes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InfoDishes_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
<<<<<<< Updated upstream:Recipes/Recipes.Core/Migrations/20221106182347_Init1.cs
                    { "17f1efb3-c24d-41f9-a1b3-46f4508cda42", "667f5fc2-c4f8-445b-af81-c9840d368a64", "Manager", "MANAGER" },
                    { "640a86e2-28ba-4b46-ac08-313fa07a1af3", "e2b582b4-0577-47b3-b806-c4650e70c545", "User", "USER" },
                    { "9f138bb5-2f5d-4919-a8f5-a26007d84eee", "a2000922-b777-4917-b048-533d3ee55d37", "Admin", "ADMIN" }
=======
                    { "049a4302-e700-42a6-a940-50ac34d3119e", "c3cb07b0-d870-4717-a24c-e39cc96f59de", "User", "USER" },
                    { "5b994991-8ebe-4455-8ec6-6153ead77c98", "e69f0e04-d50d-4edf-81b5-222e92b81d00", "Manager", "MANAGER" },
                    { "f2db02f7-1fb7-45fa-8929-8a13002ad5b6", "e0fd0926-b19f-432e-9475-55340757debf", "Admin", "ADMIN" }
>>>>>>> Stashed changes:Recipes/Recipes.Core/Migrations/20221108091710_Init2.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
<<<<<<< Updated upstream:Recipes/Recipes.Core/Migrations/20221106182347_Init1.cs
                    { "5db8c868-2c51-4928-b263-d04de8eeab4e", 0, "731d192e-c90f-4a9c-b2ec-2855a6480db8", "user@recipes.com", true, null, null, false, null, "USER@RECIPES.COM", "USER@RECIPES.COM", "AQAAAAEAACcQAAAAEOpXX0bPnu/SEoHNDlG999lCbLn8Tv1IiBweFGeELO9AE11HyWemk6UdifDDyzdteg==", null, false, "93a8e3a1-7966-4006-b9cf-1f2b0d56e740", false, "user@recipes.com" },
                    { "7a512027-4a1b-4973-a06f-34fbf92b29d8", 0, "4dc29f15-5001-40d8-a0be-d8d2fac19209", "admin@recipes.com", true, null, null, false, null, "ADMIN@RECIPES.COM", "ADMIN@RECIPES.COM", "AQAAAAEAACcQAAAAEGXHKQgdOFS54kTZwatsNwLc1izLPo891sew7SR0Asrd8PQz3FslEGuerLXFTXR+NA==", null, false, "150518a4-63c3-4b63-999b-96eff6f93a5f", false, "admin@recipes.com" },
                    { "fdac4d46-e51a-47b3-92e9-ee272eaa1451", 0, "18f942f8-1ab3-4de4-a570-19b39ae004bf", "manager@recipes.com", true, null, null, false, null, "MANAGER@RECIPES.COM", "MANAGER@RECIPES.COM", "AQAAAAEAACcQAAAAEE3zYRoiQeCdp4jJwA0qM5Y8H35b3DXrA/K/2brHm96tftFK00R+t5oHM+PEfHL9DQ==", null, false, "f636ff43-a734-44f7-b417-e5549d8da110", false, "manager@recipes.com" }
=======
                    { "0d999b5d-bd65-44e3-85a8-f600c38196f9", 0, "a436e9eb-431d-490b-812e-5519cc4f3128", "manager@recipes.com", true, null, null, false, null, "MANAGER@RECIPES.COM", "MANAGER@RECIPES.COM", "AQAAAAEAACcQAAAAEMJx6Lz++IE+FYgFM7ZRJR1Aw/oz4EcnTl8NRdZDpL56xTiVcZsxbWpTitHN2c7ruQ==", null, false, "5061513f-6fd1-4f04-83ff-3a0efe6bd11c", false, "manager@recipes.com" },
                    { "77eee32a-53c3-4b24-b14b-ef0d2fb92397", 0, "0a5a5f5a-f8d6-4388-84ea-a8dba03cf3b0", "admin@recipes.com", true, null, null, false, null, "ADMIN@RECIPES.COM", "ADMIN@RECIPES.COM", "AQAAAAEAACcQAAAAEFg4xmKNneu17R8r5jraUM+V5/xeMjK3XVxfjAH5aFDFd+QtXjEgdeXg0L3ecLFeag==", null, false, "66de81e8-9049-4fc7-af49-ae914960752b", false, "admin@recipes.com" },
                    { "e9a8c52e-1985-470a-a144-8a706acf4b54", 0, "a2451a92-02c7-454a-9a11-6bbc12427960", "user@recipes.com", true, null, null, false, null, "USER@RECIPES.COM", "USER@RECIPES.COM", "AQAAAAEAACcQAAAAEFq/8dCZ45QEPcGbkqBTaOvsVC0VR+dIC8FxtWubdeCQmZfHh4cyRPaJv7ShgZNf9w==", null, false, "6f1eebd4-5b31-4154-a1da-e5adeefeb739", false, "user@recipes.com" }
>>>>>>> Stashed changes:Recipes/Recipes.Core/Migrations/20221108091710_Init2.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
<<<<<<< Updated upstream:Recipes/Recipes.Core/Migrations/20221106182347_Init1.cs
                    { "640a86e2-28ba-4b46-ac08-313fa07a1af3", "5db8c868-2c51-4928-b263-d04de8eeab4e" },
                    { "17f1efb3-c24d-41f9-a1b3-46f4508cda42", "7a512027-4a1b-4973-a06f-34fbf92b29d8" },
                    { "640a86e2-28ba-4b46-ac08-313fa07a1af3", "7a512027-4a1b-4973-a06f-34fbf92b29d8" },
                    { "9f138bb5-2f5d-4919-a8f5-a26007d84eee", "7a512027-4a1b-4973-a06f-34fbf92b29d8" },
                    { "17f1efb3-c24d-41f9-a1b3-46f4508cda42", "fdac4d46-e51a-47b3-92e9-ee272eaa1451" },
                    { "640a86e2-28ba-4b46-ac08-313fa07a1af3", "fdac4d46-e51a-47b3-92e9-ee272eaa1451" }
=======
                    { "049a4302-e700-42a6-a940-50ac34d3119e", "0d999b5d-bd65-44e3-85a8-f600c38196f9" },
                    { "5b994991-8ebe-4455-8ec6-6153ead77c98", "0d999b5d-bd65-44e3-85a8-f600c38196f9" },
                    { "049a4302-e700-42a6-a940-50ac34d3119e", "77eee32a-53c3-4b24-b14b-ef0d2fb92397" },
                    { "5b994991-8ebe-4455-8ec6-6153ead77c98", "77eee32a-53c3-4b24-b14b-ef0d2fb92397" },
                    { "f2db02f7-1fb7-45fa-8929-8a13002ad5b6", "77eee32a-53c3-4b24-b14b-ef0d2fb92397" },
                    { "049a4302-e700-42a6-a940-50ac34d3119e", "e9a8c52e-1985-470a-a144-8a706acf4b54" }
>>>>>>> Stashed changes:Recipes/Recipes.Core/Migrations/20221108091710_Init2.cs
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_InfoDishes_CategoriesId",
                table: "InfoDishes",
                column: "CategoriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "InfoDishes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}