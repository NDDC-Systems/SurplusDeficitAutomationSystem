﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SurplusDeficitAutomationSystem.Models;

namespace SurplusDeficitAutomationSystem.Migrations.AppDb
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.BooleanField", b =>
                {
                    b.Property<int>("BooleanFieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("BooleanValue")
                        .HasColumnType("bit");

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.HasKey("BooleanFieldId");

                    b.HasIndex("FieldId");

                    b.ToTable("BooleanFields");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.Contract", b =>
                {
                    b.Property<int>("ContractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Balance")
                        .HasColumnType("real");

                    b.Property<string>("ContractName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProviderId")
                        .HasColumnType("int");

                    b.Property<int>("TemplateId")
                        .HasColumnType("int");

                    b.HasKey("ContractId");

                    b.HasIndex("ProviderId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.DateTimeField", b =>
                {
                    b.Property<int>("DateTimeFieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTimeValue")
                        .HasColumnType("datetime2");

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.HasKey("DateTimeFieldId");

                    b.HasIndex("FieldId");

                    b.ToTable("DateTimeFields");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.Field", b =>
                {
                    b.Property<int>("FieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FieldName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FieldId");

                    b.ToTable("Fields");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.FloatField", b =>
                {
                    b.Property<int>("FloatFieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.Property<float>("FloatValue")
                        .HasColumnType("real");

                    b.HasKey("FloatFieldId");

                    b.HasIndex("FieldId");

                    b.ToTable("FloatFields");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.IntField", b =>
                {
                    b.Property<int>("IntFieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.Property<int>("IntValue")
                        .HasColumnType("int");

                    b.HasKey("IntFieldId");

                    b.HasIndex("FieldId");

                    b.ToTable("IntFields");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.Provider", b =>
                {
                    b.Property<int>("ProviderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProviderId");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.ProviderToContract", b =>
                {
                    b.Property<int>("ProviderToContractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.HasKey("ProviderToContractId");

                    b.HasIndex("ContractId");

                    b.HasIndex("ProviderId");

                    b.ToTable("ProviderToContract");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.Report", b =>
                {
                    b.Property<int>("ReportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<bool>("Approved")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ApprovedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubmitDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TemplateId")
                        .HasColumnType("int");

                    b.HasKey("ReportId");

                    b.HasIndex("AdminId");

                    b.HasIndex("ContractId");

                    b.HasIndex("TemplateId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.ReportFieldValues", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.Property<int>("ReportId")
                        .HasColumnType("int");

                    b.Property<int>("ValueId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ReportFieldValues");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.StringField", b =>
                {
                    b.Property<int>("StringFieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.Property<string>("StringValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StringFieldId");

                    b.HasIndex("FieldId");

                    b.ToTable("StringFields");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.Template", b =>
                {
                    b.Property<int>("TemplateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TemplateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TemplateId");

                    b.ToTable("Templates");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.TemplateFields", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.Property<int>("TemplateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TemplateFields");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.TemplateToField", b =>
                {
                    b.Property<int>("TemplateToFieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.Property<int>("TemplateId")
                        .HasColumnType("int");

                    b.HasKey("TemplateToFieldId");

                    b.HasIndex("FieldId");

                    b.HasIndex("TemplateId");

                    b.ToTable("TemplateToField");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.TextField", b =>
                {
                    b.Property<int>("TextFieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.Property<string>("TextValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TextFieldId");

                    b.HasIndex("FieldId");

                    b.ToTable("TextFields");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.Value", b =>
                {
                    b.Property<int>("ValueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("BooleanValue")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateTimeValue")
                        .HasColumnType("datetime2");

                    b.Property<float>("FloatValue")
                        .HasColumnType("real");

                    b.Property<int>("IntValue")
                        .HasColumnType("int");

                    b.Property<string>("StringValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TextValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ValueId");

                    b.ToTable("Values");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.BooleanField", b =>
                {
                    b.HasOne("SurplusDeficitAutomationSystem.Models.Field", "Field")
                        .WithMany("BooleanFields")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.Contract", b =>
                {
                    b.HasOne("SurplusDeficitAutomationSystem.Models.Provider", "Provider")
                        .WithMany("Contracts")
                        .HasForeignKey("ProviderId");

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.DateTimeField", b =>
                {
                    b.HasOne("SurplusDeficitAutomationSystem.Models.Field", "Field")
                        .WithMany("DateTimeFields")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.FloatField", b =>
                {
                    b.HasOne("SurplusDeficitAutomationSystem.Models.Field", "Field")
                        .WithMany("FloatFields")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.IntField", b =>
                {
                    b.HasOne("SurplusDeficitAutomationSystem.Models.Field", "Field")
                        .WithMany("IntFields")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.ProviderToContract", b =>
                {
                    b.HasOne("SurplusDeficitAutomationSystem.Models.Contract", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SurplusDeficitAutomationSystem.Models.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contract");

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.Report", b =>
                {
                    b.HasOne("SurplusDeficitAutomationSystem.Models.Admin", "Admin")
                        .WithMany("Reports")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SurplusDeficitAutomationSystem.Models.Contract", "Contract")
                        .WithMany("Reports")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SurplusDeficitAutomationSystem.Models.Template", "Template")
                        .WithMany("Reports")
                        .HasForeignKey("TemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Contract");

                    b.Navigation("Template");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.StringField", b =>
                {
                    b.HasOne("SurplusDeficitAutomationSystem.Models.Field", "Field")
                        .WithMany("StringFields")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.TemplateToField", b =>
                {
                    b.HasOne("SurplusDeficitAutomationSystem.Models.Field", "Field")
                        .WithMany("TemplatesToFields")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SurplusDeficitAutomationSystem.Models.Template", "Template")
                        .WithMany("TemplatesToFields")
                        .HasForeignKey("TemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");

                    b.Navigation("Template");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.TextField", b =>
                {
                    b.HasOne("SurplusDeficitAutomationSystem.Models.Field", "Field")
                        .WithMany("TextFields")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.Admin", b =>
                {
                    b.Navigation("Reports");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.Contract", b =>
                {
                    b.Navigation("Reports");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.Field", b =>
                {
                    b.Navigation("BooleanFields");

                    b.Navigation("DateTimeFields");

                    b.Navigation("FloatFields");

                    b.Navigation("IntFields");

                    b.Navigation("StringFields");

                    b.Navigation("TemplatesToFields");

                    b.Navigation("TextFields");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.Provider", b =>
                {
                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("SurplusDeficitAutomationSystem.Models.Template", b =>
                {
                    b.Navigation("Reports");

                    b.Navigation("TemplatesToFields");
                });
#pragma warning restore 612, 618
        }
    }
}
