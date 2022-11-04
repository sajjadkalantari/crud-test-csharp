﻿// <auto-generated />
using System;
using Mc2.CrudTest.Presentation.Infrustructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mc2.CrudTest.Presentation.Infrustructure.Migrations
{
    [DbContext(typeof(CustomerContext))]
    [Migration("20221103113356_UpdateCustomerValueTypes")]
    partial class UpdateCustomerValueTypes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mc2.CrudTest.Presentation.Domain.AggregatesModel.CustomerAggregate.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("DateOfBirth", "Firstname", "Lastname")
                        .IsUnique();

                    b.ToTable("customers", "customer");
                });

            modelBuilder.Entity("Mc2.CrudTest.Presentation.Domain.AggregatesModel.CustomerAggregate.Customer", b =>
                {
                    b.OwnsOne("Mc2.CrudTest.Presentation.Domain.AggregatesModel.CustomerAggregate.BankAccountNumberValueObject", "BankAccountNumber", b1 =>
                        {
                            b1.Property<int>("CustomerId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("BankAccountNumber")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("nvarchar(200)")
                                .HasColumnName("BankAccountNumber");

                            b1.HasKey("CustomerId");

                            b1.ToTable("customers");

                            b1.WithOwner()
                                .HasForeignKey("CustomerId");
                        });

                    b.OwnsOne("Mc2.CrudTest.Presentation.Domain.AggregatesModel.CustomerAggregate.EmailValueObject", "Email", b1 =>
                        {
                            b1.Property<int>("CustomerId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("nvarchar(200)")
                                .HasColumnName("Email");

                            b1.HasKey("CustomerId");

                            b1.HasIndex("Email")
                                .IsUnique()
                                .HasFilter("[Email] IS NOT NULL");

                            b1.ToTable("customers");

                            b1.WithOwner()
                                .HasForeignKey("CustomerId");
                        });

                    b.OwnsOne("Mc2.CrudTest.Presentation.Domain.AggregatesModel.CustomerAggregate.PhoneNumberValueObject", "PhoneNumber", b1 =>
                        {
                            b1.Property<int>("CustomerId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<decimal>("PhoneNumber")
                                .HasColumnType("decimal(20,0)")
                                .HasColumnName("PhoneNumber");

                            b1.HasKey("CustomerId");

                            b1.ToTable("customers");

                            b1.WithOwner()
                                .HasForeignKey("CustomerId");
                        });

                    b.Navigation("BankAccountNumber");

                    b.Navigation("Email");

                    b.Navigation("PhoneNumber");
                });
#pragma warning restore 612, 618
        }
    }
}
