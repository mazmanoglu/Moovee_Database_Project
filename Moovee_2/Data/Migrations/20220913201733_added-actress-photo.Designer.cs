﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Moovee_2.Data;

namespace Moovee_2.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220913201733_added-actress-photo")]
    partial class addedactressphoto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
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

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Moovee_2.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActressImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateRelease")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImdbUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("MainActress")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            ActressImage = "katewinslet.jpg",
                            DateRelease = new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic",
                            Genre = "Romance",
                            ImageUrl = "Titanic.jpg",
                            ImdbUrl = "https://www.imdb.com/title/tt0120338/",
                            Length = 125,
                            MainActress = "Kate Winslet",
                            Title = "Titanic"
                        },
                        new
                        {
                            MovieId = 2,
                            DateRelease = new DateTime(2009, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "In Nazi-occupied France during World War II, a plan to assasinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same",
                            Genre = "Action",
                            ImageUrl = "InBasterds.jpg",
                            ImdbUrl = "https://www.imdb.com/title/tt0361748/",
                            Length = 105,
                            MainActress = "Diane Kruger",
                            Title = "Inglorious Basterds"
                        },
                        new
                        {
                            MovieId = 3,
                            DateRelease = new DateTime(2013, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "After the crew of the Enterprise find an unstoppable force of terror from within their own organization, Captain Kirk leads a manhunt to a war-zone world to capture a one-man weapon of mass destruction",
                            Genre = "Sci-Fi",
                            ImageUrl = "StarTrek.jpg",
                            ImdbUrl = "https://www.imdb.com/title/tt1408101/",
                            Length = 135,
                            MainActress = "Zoe Saldana",
                            Title = "Star Trek - Into Darkness"
                        },
                        new
                        {
                            MovieId = 4,
                            DateRelease = new DateTime(1986, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "As students at the United States Navy's elite fighter weapons school compete to be best in the class, one daring young pilot learns a few things from a civilian instructor that are not taught in the classroom.",
                            Genre = "Action-Drama",
                            ImageUrl = "topgun.jpg",
                            ImdbUrl = "https://www.imdb.com/title/tt0092099/",
                            Length = 110,
                            MainActress = "Kelly McGills",
                            Title = "Top Gun"
                        },
                        new
                        {
                            MovieId = 5,
                            DateRelease = new DateTime(1972, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.",
                            Genre = "Crime / Drama",
                            ImageUrl = "godfather.jpg",
                            ImdbUrl = "https://www.imdb.com/title/tt0068646/",
                            Length = 175,
                            MainActress = "Simonetta Stefanelli",
                            Title = "The Godfather"
                        },
                        new
                        {
                            MovieId = 6,
                            DateRelease = new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Set in the '30s, it follows three friends who witness a murder, become suspects themselves, and uncover one of the most outrageous plots in American history.",
                            Genre = "Drama / History",
                            ImageUrl = "amsterdam.jpg",
                            ImdbUrl = "https://www.imdb.com/title/tt10304142/",
                            Length = 100,
                            MainActress = "Margot Robbie",
                            Title = "Amsterdam"
                        });
                });

            modelBuilder.Entity("Moovee_2.Models.TvShow", b =>
                {
                    b.Property<int>("TvShowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateRelease")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImdbUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("MainActress")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TvShowId");

                    b.ToTable("TvShows");

                    b.HasData(
                        new
                        {
                            TvShowId = 1,
                            DateRelease = new DateTime(2011, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.",
                            Genre = "Action / Fantasy",
                            ImageUrl = "gameofthrones.jpg",
                            ImdbUrl = "https://www.imdb.com/title/tt0944947/",
                            Length = 140,
                            MainActress = "Emilia Clarke",
                            Title = "Game of Thrones"
                        },
                        new
                        {
                            TvShowId = 3,
                            DateRelease = new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.",
                            Genre = "Science",
                            ImageUrl = "breakingbad.jpg",
                            ImdbUrl = "https://www.imdb.com/title/tt0903747/",
                            Length = 62,
                            MainActress = "Anna Gunn",
                            Title = "Breaking Bad"
                        },
                        new
                        {
                            TvShowId = 4,
                            DateRelease = new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Epic drama set thousands of years before the events of J.R.R. Tolkien's 'The Hobbit' and 'The Lord of the Rings' follows an ensemble cast of characters, both familiar and new, as they confront the long-feared re-emergence of evil to Middle-earth.",
                            Genre = "Sci-Fi / Fantasy",
                            ImageUrl = "ringsofpower.jpg",
                            ImdbUrl = "https://www.imdb.com/title/tt7631058/",
                            Length = 10,
                            MainActress = "Morfydd Clark",
                            Title = "Lord of the Rings - Rings Power"
                        },
                        new
                        {
                            TvShowId = 5,
                            DateRelease = new DateTime(2001, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The story of Easy Company of the U.S. Army 101st Airborne Division and their mission in World War II Europe, from Operation Overlord to V-J Day.",
                            Genre = "Drama / History / War",
                            ImageUrl = "bandofbrothers.jpg",
                            ImdbUrl = "https://www.imdb.com/title/tt0185906/",
                            Length = 10,
                            MainActress = "----",
                            Title = "Band of Brothers"
                        },
                        new
                        {
                            TvShowId = 6,
                            DateRelease = new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "In April 1986, an explosion at the Chernobyl nuclear power plant in the Union of Soviet Socialist Republics becomes one of the world's worst man-made catastrophes.",
                            Genre = "Drama / History / Thriller",
                            ImageUrl = "chernobyl.jpg",
                            ImdbUrl = "https://www.imdb.com/title/tt7366338/",
                            Length = 5,
                            MainActress = "Jessie Buckley",
                            Title = "Chernobyl"
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
#pragma warning restore 612, 618
        }
    }
}
