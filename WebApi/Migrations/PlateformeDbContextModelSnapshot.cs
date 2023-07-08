﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Data;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(PlateformeDbContext))]
    partial class PlateformeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("WebApi.Models.AideSoignanteModel", b =>
                {
                    b.Property<int>("IdAS")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BirthDateAs")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BirthPlaceAs")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CityAS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CountryAS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DiplomaTitleAS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAs")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstNameAs")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastNameAs")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MaritalStatusAS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordAS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneAs")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SocialStatusAS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkplaceAS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ZipcodeAS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdAS");

                    b.ToTable("AideSoignantes");
                });

            modelBuilder.Entity("WebApi.Models.DiagnosticModel", b =>
                {
                    b.Property<int>("IdDiagnostic")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AmenitiesDiagnostic")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AssistantDiagnostic")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AssistantDistDiagnostic")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("AssuranceContractDiagnostic")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BuildingPeriodDiagnostic")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("CommunePartiDiagnostic")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ConditionerAirDiagnostic")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DetectorDiagnostic")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("DispositifDiagnostic")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FellTimeDiagnostic")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("HealthMonitoringDiagnostic")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HearingProblemDiagnostic")
                        .HasColumnType("INTEGER");

                    b.Property<string>("HobbiesDiagnostic")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HotHomeDiagnostic")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("IdPA")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("MarcheAccesDiagnostic")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("MemoryProblemDiagnostic")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NameSportDiagnostic")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("NecessaryAccompanimentDiagnostic")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("PracticeSportDiagnostic")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TransportMethodPA")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("VisualProblemDiagnostic")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdDiagnostic");

                    b.ToTable("Diagnostics");
                });

            modelBuilder.Entity("WebApi.Models.LoginModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("WebApi.Models.PartenaireModel", b =>
                {
                    b.Property<int>("idPart")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NamePart")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TypePart")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("idPart");

                    b.ToTable("Partenaires");
                });

            modelBuilder.Entity("WebApi.Models.PersonneAgeModel", b =>
                {
                    b.Property<int>("IdPA")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BirthdatePA")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BirthplacePA")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CityPA")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CountryPA")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstNamePA")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HousingTypePA")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastNamePA")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MaritalStatusAS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PropertyTypePA")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SocialStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdPA");

                    b.ToTable("PersonneAges");
                });

            modelBuilder.Entity("WebApi.Models.UtilisateurModel", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BirthDateUser")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BirthPlaceUser")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CitizenshipUser")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CityUser")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailUser")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstNameUser")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastNameUser")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MaritalStatusUser")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneUser")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SocialStatusUser")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StateUser")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetUser")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ZipcodeUser")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdUser");

                    b.ToTable("Utilisateurs");

                    b.HasDiscriminator<string>("Discriminator").HasValue("UtilisateurModel");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("WebApi.Models.AdministrateurModel", b =>
                {
                    b.HasBaseType("WebApi.Models.UtilisateurModel");

                    b.Property<int>("IdAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PasswordAdmin")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UsernameAdmin")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("AdministrateurModel");
                });
#pragma warning restore 612, 618
        }
    }
}
