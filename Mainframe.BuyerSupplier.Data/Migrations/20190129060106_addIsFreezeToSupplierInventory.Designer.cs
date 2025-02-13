﻿// <auto-generated />
using System;
using Mainframe.BuyerSupplier.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mainframe.BuyerSupplier.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190129060106_addIsFreezeToSupplierInventory")]
    partial class addIsFreezeToSupplierInventory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mainframe.BuyerSupplier.Data.Models.Delivery", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactNo");

                    b.Property<string>("ContactPerson");

                    b.Property<DateTime>("DeliveryDate");

                    b.Property<DateTime>("DeliveryTime");

                    b.Property<int>("OrderID");

                    b.Property<int>("Status");

                    b.Property<string>("VehicleNo");

                    b.HasKey("ID");

                    b.ToTable("Delivery");
                });

            modelBuilder.Entity("Mainframe.BuyerSupplier.Data.Models.DeliveryCostConfiguration", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdditionalRate");

                    b.Property<int>("BaseDistance");

                    b.Property<int>("BaseFare");

                    b.Property<int>("BaseLocationID");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("DeliveryCostConfiguration");
                });

            modelBuilder.Entity("Mainframe.BuyerSupplier.Data.Models.DeliverySlots", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountdownTime");

                    b.Property<string>("CutoffTime");

                    b.Property<string>("DispatchesConfirmTime");

                    b.Property<string>("EndTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("OrderAcceptTime");

                    b.Property<string>("OrderCofirmTime");

                    b.Property<string>("SlotName");

                    b.Property<string>("StartTime");

                    b.HasKey("ID");

                    b.ToTable("DeliverySlots");
                });

            modelBuilder.Entity("Mainframe.BuyerSupplier.Data.Models.FileServerDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BucketName");

                    b.Property<string>("Key");

                    b.HasKey("ID");

                    b.ToTable("FileServerDetail");
                });

            modelBuilder.Entity("Mainframe.BuyerSupplier.Data.Models.InventoryItemCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("InventoryItemCategory");
                });

            modelBuilder.Entity("Mainframe.BuyerSupplier.Data.Models.InventoryItemSubCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("InventoryItemCategoryID");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("InventoryItemSubCategory");
                });

            modelBuilder.Entity("Mainframe.BuyerSupplier.Data.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BuyerId");

                    b.Property<int>("DeliverySlotId");

                    b.Property<DateTime>("ExpectedDiliveredDate");

                    b.Property<bool>("IsPreOrder");

                    b.Property<string>("OrderRefNo");

                    b.Property<DateTime>("OrderedDate");

                    b.Property<int>("Status");

                    b.Property<string>("SupplierCategory");

                    b.HasKey("ID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Mainframe.BuyerSupplier.Data.Models.OrderAssignment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("BuyerAcknowledgement");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("OrderDetailID");

                    b.Property<decimal>("Qty");

                    b.Property<bool>("SupplierAcknowledgement");

                    b.Property<int>("SupplierInventoryID");

                    b.Property<bool>("VehicleAcknowledgement");

                    b.HasKey("ID");

                    b.ToTable("OrderAssignment");
                });

            modelBuilder.Entity("Mainframe.BuyerSupplier.Data.Models.OrderDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("OrderID");

                    b.Property<decimal>("Qty");

                    b.Property<int>("StandardInventoryId");

                    b.HasKey("ID");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("Mainframe.BuyerSupplier.Data.Models.StandardInventory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FileServerDetailID");

                    b.Property<int>("InventoryItemCategoryId");

                    b.Property<int>("InventoryItemSubCategoryId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ItemName");

                    b.Property<decimal>("MinimumInventory");

                    b.Property<int>("QuantityUnitOfMesureId");

                    b.Property<string>("Seasonality");

                    b.HasKey("ID");

                    b.ToTable("StandardInventory");
                });

            modelBuilder.Entity("Mainframe.BuyerSupplier.Data.Models.SupplierBase", b =>
                {
                    b.Property<int>("SupplierBaseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeliverySlot");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("SupplierBaseName");

                    b.HasKey("SupplierBaseId");

                    b.ToTable("SupplierBase");
                });

            modelBuilder.Entity("Mainframe.BuyerSupplier.Data.Models.SupplierInventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AvailableQty");

                    b.Property<DateTime>("InventoryDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsFreeze");

                    b.Property<decimal>("ProcessingQty");

                    b.Property<decimal>("Qty");

                    b.Property<int>("StandardInventoryId");

                    b.Property<int>("SupplierStandardInventoryId");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("Id");

                    b.HasIndex("SupplierStandardInventoryId");

                    b.ToTable("SupplierInventory");
                });

            modelBuilder.Entity("Mainframe.BuyerSupplier.Data.Models.SupplierStandardInventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsSelected");

                    b.Property<int>("StandardInventoryId");

                    b.Property<int>("SupplierId");

                    b.HasKey("Id");

                    b.HasIndex("StandardInventoryId");

                    b.ToTable("SupplierStandardInventory");
                });

            modelBuilder.Entity("Mainframe.BuyerSupplier.Data.Models.TimeWave", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<TimeSpan>("Time");

                    b.HasKey("ID");

                    b.ToTable("TimeWave");
                });

            modelBuilder.Entity("Mainframe.BuyerSupplier.Data.Models.UnitOfMeasure", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("UnitOfMeasure");
                });

            modelBuilder.Entity("Mainframe.BuyerSupplier.Data.Models.Users", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Category");

                    b.Property<string>("ContactNo");

                    b.Property<int>("DefaultSupplierBaseId");

                    b.Property<int>("DeliverySlotId");

                    b.Property<string>("Email");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("RelevantZoneId");

                    b.Property<int>("StandaradInventoryID");

                    b.Property<string>("UserType");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Mainframe.BuyerSupplier.Data.Models.UserSupplierBase", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Distance");

                    b.Property<int>("SupplierBaseID");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.ToTable("UserSupplierBase");
                });

            modelBuilder.Entity("Mainframe.BuyerSupplier.Data.Models.Vehicle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Availabiity");

                    b.Property<string>("DriverContactNo");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("NumberPlate");

                    b.Property<int>("SupplierBaseId");

                    b.Property<int>("VehicleTypeId");

                    b.HasKey("ID");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("Mainframe.BuyerSupplier.Data.Models.VehicleType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("VehicleType");
                });

            modelBuilder.Entity("Mainframe.BuyerSupplier.Data.Models.Zone", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("SupplierBaseID");

                    b.HasKey("ID");

                    b.ToTable("Zone");
                });

            modelBuilder.Entity("Mainframe.BuyerSupplier.Data.Models.SupplierInventory", b =>
                {
                    b.HasOne("Mainframe.BuyerSupplier.Data.Models.SupplierStandardInventory", "SupplierStandardInventory")
                        .WithMany()
                        .HasForeignKey("SupplierStandardInventoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Mainframe.BuyerSupplier.Data.Models.SupplierStandardInventory", b =>
                {
                    b.HasOne("Mainframe.BuyerSupplier.Data.Models.StandardInventory", "StandardInventory")
                        .WithMany()
                        .HasForeignKey("StandardInventoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
