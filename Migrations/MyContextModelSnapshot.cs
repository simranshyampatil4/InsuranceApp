﻿// <auto-generated />
using System;
using InsuranceApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InsuranceApp.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InsuranceApp.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AdminId");

                    b.HasIndex("UserId");

                    b.ToTable("Admins", (string)null);
                });

            modelBuilder.Entity("InsuranceApp.Models.Agent", b =>
                {
                    b.Property<int>("AgentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AgentId"));

                    b.Property<double>("CommissionEarned")
                        .HasColumnType("float");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AgentId");

                    b.HasIndex("UserId");

                    b.ToTable("Agents", (string)null);
                });

            modelBuilder.Entity("InsuranceApp.Models.Claim", b =>
                {
                    b.Property<int>("ClaimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClaimId"));

                    b.Property<double>("BankAccountNumber")
                        .HasColumnType("float");

                    b.Property<string>("BankIfscCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ClaimAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("PolicyNo")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClaimId");

                    b.ToTable("Claims", (string)null);
                });

            modelBuilder.Entity("InsuranceApp.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<int>("AgentId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nominee")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomineeRelation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.HasIndex("AgentId");

                    b.ToTable("Customers", (string)null);
                });

            modelBuilder.Entity("InsuranceApp.Models.Document", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocumentId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<byte[]>("DocumentFile")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("DocumentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("DocumentId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Documents", (string)null);
                });

            modelBuilder.Entity("InsuranceApp.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("UserId");

                    b.ToTable("Employees", (string)null);
                });

            modelBuilder.Entity("InsuranceApp.Models.InsurancePlan", b =>
                {
                    b.Property<int>("PlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlanId"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PlanName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlanId");

                    b.ToTable("InsurancePlans", (string)null);
                });

            modelBuilder.Entity("InsuranceApp.Models.InsurancePolicy", b =>
                {
                    b.Property<int>("PolicyNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PolicyNo"));

                    b.Property<int>("ClaimId")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("InsuranceSchemeSchemeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MaturityDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.Property<int>("PlanId")
                        .HasColumnType("int");

                    b.Property<double>("PremiumAmount")
                        .HasColumnType("float");

                    b.Property<string>("PremiumType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SumAssured")
                        .HasColumnType("float");

                    b.HasKey("PolicyNo");

                    b.HasIndex("ClaimId")
                        .IsUnique();

                    b.HasIndex("CustomerId");

                    b.HasIndex("InsuranceSchemeSchemeId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("PlanId");

                    b.ToTable("InsurancePolicies", (string)null);
                });

            modelBuilder.Entity("InsuranceApp.Models.InsuranceScheme", b =>
                {
                    b.Property<int>("SchemeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SchemeId"));

                    b.Property<int>("DetailId")
                        .HasColumnType("int");

                    b.Property<int>("InsurancePlansPlanId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("PlanId")
                        .HasColumnType("int");

                    b.Property<string>("SchemeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SchemeId");

                    b.HasIndex("DetailId");

                    b.HasIndex("InsurancePlansPlanId");

                    b.ToTable("InsuranceSchemes", (string)null);
                });

            modelBuilder.Entity("InsuranceApp.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Tax")
                        .HasColumnType("float");

                    b.Property<double>("TotalPayment")
                        .HasColumnType("float");

                    b.HasKey("PaymentId");

                    b.ToTable("Payments", (string)null);
                });

            modelBuilder.Entity("InsuranceApp.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("InsuranceApp.Models.SchemeDetails", b =>
                {
                    b.Property<int>("DetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetailId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("InstallmentCommRatio")
                        .HasColumnType("float");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MaxAge")
                        .HasColumnType("int");

                    b.Property<double>("MaxAmount")
                        .HasColumnType("float");

                    b.Property<int>("MaxInvestmentTime")
                        .HasColumnType("int");

                    b.Property<int>("MinAge")
                        .HasColumnType("int");

                    b.Property<double>("MinAmount")
                        .HasColumnType("float");

                    b.Property<int>("MinInvestmentTime")
                        .HasColumnType("int");

                    b.Property<double>("ProfitRatio")
                        .HasColumnType("float");

                    b.Property<double>("RegistrationCommRatio")
                        .HasColumnType("float");

                    b.Property<string>("SchemeImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DetailId");

                    b.ToTable("SchemeDetails", (string)null);
                });

            modelBuilder.Entity("InsuranceApp.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("InsuranceApp.Models.Admin", b =>
                {
                    b.HasOne("InsuranceApp.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("InsuranceApp.Models.Agent", b =>
                {
                    b.HasOne("InsuranceApp.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("InsuranceApp.Models.Customer", b =>
                {
                    b.HasOne("InsuranceApp.Models.Agent", "Agent")
                        .WithMany("Customers")
                        .HasForeignKey("AgentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agent");
                });

            modelBuilder.Entity("InsuranceApp.Models.Document", b =>
                {
                    b.HasOne("InsuranceApp.Models.Customer", "Customer")
                        .WithMany("Documents")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("InsuranceApp.Models.Employee", b =>
                {
                    b.HasOne("InsuranceApp.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("InsuranceApp.Models.InsurancePolicy", b =>
                {
                    b.HasOne("InsuranceApp.Models.Claim", "Claim")
                        .WithOne("Policy")
                        .HasForeignKey("InsuranceApp.Models.InsurancePolicy", "ClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceApp.Models.Customer", null)
                        .WithMany("InsurancePolicies")
                        .HasForeignKey("CustomerId");

                    b.HasOne("InsuranceApp.Models.InsuranceScheme", null)
                        .WithMany("Policies")
                        .HasForeignKey("InsuranceSchemeSchemeId");

                    b.HasOne("InsuranceApp.Models.Payment", "PaidPremiums")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceApp.Models.InsurancePlan", "InsurancePlan")
                        .WithMany()
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Claim");

                    b.Navigation("InsurancePlan");

                    b.Navigation("PaidPremiums");
                });

            modelBuilder.Entity("InsuranceApp.Models.InsuranceScheme", b =>
                {
                    b.HasOne("InsuranceApp.Models.SchemeDetails", "SchemeDetails")
                        .WithMany()
                        .HasForeignKey("DetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceApp.Models.InsurancePlan", "InsurancePlans")
                        .WithMany("insuranceSchemes")
                        .HasForeignKey("InsurancePlansPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InsurancePlans");

                    b.Navigation("SchemeDetails");
                });

            modelBuilder.Entity("InsuranceApp.Models.User", b =>
                {
                    b.HasOne("InsuranceApp.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("InsuranceApp.Models.Agent", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("InsuranceApp.Models.Claim", b =>
                {
                    b.Navigation("Policy")
                        .IsRequired();
                });

            modelBuilder.Entity("InsuranceApp.Models.Customer", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("InsurancePolicies");
                });

            modelBuilder.Entity("InsuranceApp.Models.InsurancePlan", b =>
                {
                    b.Navigation("insuranceSchemes");
                });

            modelBuilder.Entity("InsuranceApp.Models.InsuranceScheme", b =>
                {
                    b.Navigation("Policies");
                });
#pragma warning restore 612, 618
        }
    }
}
