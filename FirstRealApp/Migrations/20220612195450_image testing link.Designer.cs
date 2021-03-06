// <auto-generated />
using System;
using FirstRealApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirstRealApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220612195450_image testing link")]
    partial class imagetestinglink
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FirstRealApp.Models.ApplicationUser", b =>
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
                });

            modelBuilder.Entity("FirstRealApp.Models.PoodleEntity.Poodle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("GeneticTests")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PedigreeNumber")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int?>("PoodleColorId")
                        .HasColumnType("int");

                    b.Property<int?>("PoodleSizeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PoodleColorId");

                    b.HasIndex("PoodleSizeId");

                    b.ToTable("Poodles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GeneticTests = true,
                            Image = "https://lh3.googleusercontent.com/YUU9X3jy86ikEty5cx48BYA9E9REm62qmA4fyTMHQfw1KRMDZT5ye2LaK_7YZZmim838iTTYiidzaoX1Cs35UmtKBKdi7JgPHfQYZx7NJxZEN8ibR2zrUFNbz_qrFmsTIElIG3SflcHNH9IL4f28zvIjeBUc67xFNp51r2pohsD9zP3njqQ-WhB2zsd2GAGZIj3I6r6lOGfgWBamReWF_sa0-Itg7k5ERWWxXhQlhM8Y9mvyMTkMm-s2ZmwiEymzLqw8pEymEioTIwIvW9atTlvv8oXyEMmNPvBnwQsZzRjxw7XOubRTifjFI25IC_0RY-uWkBJIHxybhmkl39IRCfzmORSo0s9j5jmMN4-vsVJH6Pl-wDYrdARMb8kDaGmkUczj3JV3SUmunJHyj01q4HJHmLbx6IgRbBjvmP3Kpm6zFSpCh51UqQs06o6KCEpa4qCR8zwKALhfBWyKgeEVjEMAScRAbJc7x-CeF9Z4L4pK-sJQlTuoEIJ_D-0MtXnuB0I8wUks6wAlkKj_YYLB8nal3UUiP0uN2czrYKY-LI6Id4CfInMA460dCsMmam0F5OPno7Pi6d1z3qplMSXLLj6mqtHLP6TKNZXgoyUGnUgEAuu4Qj-Wv7pzVCbD0fLIC3ZhHCChiX7NjDaT-NOOc-M1aqGyrsiKtea7kG24mgKY780X5kagBOJn3_0XpxYC9JoY4NrVk27Y2Oao5TvHxlmgXLDdx4hzjnAWHvhOsatL72XrmzHYzfh0lJQ=w750-h937-no?authuser=0",
                            Name = "Toy Love Story Don Juan",
                            PedigreeNumber = "JR 70883",
                            PoodleColorId = 6,
                            PoodleSizeId = 2
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(2020, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GeneticTests = false,
                            Image = "test",
                            Name = "Cici",
                            PedigreeNumber = "JR 81231",
                            PoodleColorId = 5,
                            PoodleSizeId = 2
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(2018, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GeneticTests = true,
                            Image = "test",
                            Name = "Greta Garbo Von Apalusso",
                            PedigreeNumber = "JR 70883",
                            PoodleColorId = 5,
                            PoodleSizeId = 2
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GeneticTests = true,
                            Image = "test3",
                            Name = "Scarlet Rain  Von Apalusso",
                            PedigreeNumber = "JR 70883",
                            PoodleColorId = 6,
                            PoodleSizeId = 1
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GeneticTests = false,
                            Image = "test22",
                            Name = "Skyler Von Apalusso",
                            PedigreeNumber = "JR 70883",
                            PoodleColorId = 6,
                            PoodleSizeId = 2
                        },
                        new
                        {
                            Id = 6,
                            DateOfBirth = new DateTime(2017, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GeneticTests = true,
                            Image = "test123",
                            Name = "Loko Loko Crveni Mayestoso",
                            PedigreeNumber = "JR 70883",
                            PoodleColorId = 7,
                            PoodleSizeId = 1
                        });
                });

            modelBuilder.Entity("FirstRealApp.Models.PoodleEntity.PoodleColor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PoodleColors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Black"
                        },
                        new
                        {
                            Id = 2,
                            Name = "White"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Brown"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Gray"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Apricot"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Red"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Black and tan"
                        });
                });

            modelBuilder.Entity("FirstRealApp.Models.PoodleEntity.PoodleSize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PoodleSizes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Toy"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Miniature"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Medium"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Standard"
                        });
                });

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

            modelBuilder.Entity("FirstRealApp.Models.PoodleEntity.Poodle", b =>
                {
                    b.HasOne("FirstRealApp.Models.PoodleEntity.PoodleColor", "PoodleColor")
                        .WithMany()
                        .HasForeignKey("PoodleColorId");

                    b.HasOne("FirstRealApp.Models.PoodleEntity.PoodleSize", "PoodleSize")
                        .WithMany()
                        .HasForeignKey("PoodleSizeId");

                    b.Navigation("PoodleColor");

                    b.Navigation("PoodleSize");
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
                    b.HasOne("FirstRealApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FirstRealApp.Models.ApplicationUser", null)
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

                    b.HasOne("FirstRealApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FirstRealApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
