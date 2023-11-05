﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ms_parcela.Database;

#nullable disable

namespace msparcela.Migrations
{
    [DbContext(typeof(AuctionLandAPIContext))]
    [Migration("20230211000722_Fourth Migration")]
    partial class FourthMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ms_parcela.Models.DeoParceleModel.DeoParcele", b =>
                {
                    b.Property<Guid>("deoParceleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("povrsinaDelaParcele")
                        .HasColumnType("int");

                    b.Property<int>("redniBrojDelaParcele")
                        .HasColumnType("int");

                    b.HasKey("deoParceleID");

                    b.ToTable("DeoParceles");

                    b.HasData(
                        new
                        {
                            deoParceleID = new Guid("8d2314af-5e3f-4dcd-ad7a-5095e6c39ffa"),
                            povrsinaDelaParcele = 200,
                            redniBrojDelaParcele = 3
                        },
                        new
                        {
                            deoParceleID = new Guid("14d41623-6793-47d0-865d-f0780bd72bc1"),
                            povrsinaDelaParcele = 200,
                            redniBrojDelaParcele = 4
                        });
                });

            modelBuilder.Entity("ms_parcela.Models.KatastarskaOpstinaModel.KatastarskaOpstina", b =>
                {
                    b.Property<Guid>("brojKatastarskeOpstine")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nazivKatastarskeOpstine")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("brojKatastarskeOpstine");

                    b.ToTable("KatastarskaOpstinas");

                    b.HasData(
                        new
                        {
                            brojKatastarskeOpstine = new Guid("22ae87fe-847f-4f35-bbe9-18bab36f2bda"),
                            nazivKatastarskeOpstine = "Cantavir"
                        },
                        new
                        {
                            brojKatastarskeOpstine = new Guid("faea4c2a-5338-4be2-a5be-1c63bcaf232f"),
                            nazivKatastarskeOpstine = "Bajmok"
                        });
                });

            modelBuilder.Entity("ms_parcela.Models.ParcelaModel.Parcela", b =>
                {
                    b.Property<Guid>("brojKatastraskaOpstina")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("brojParcele")
                        .HasColumnType("int");

                    b.Property<string>("klasa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("kultura")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("oblikSvojine")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("obradivost")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("odvodnjavanje")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("povrsina")
                        .HasColumnType("int");

                    b.HasKey("brojKatastraskaOpstina", "brojParcele");

                    b.ToTable("Parcelas");
                });

            modelBuilder.Entity("ms_parcela.Models.ZonaModel.Zona", b =>
                {
                    b.Property<Guid>("zonaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("brojZona")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("zonaID");

                    b.ToTable("Zonas");

                    b.HasData(
                        new
                        {
                            zonaID = new Guid("8f522aa3-70c2-4d67-8f3d-e23684654650"),
                            brojZona = "zona3"
                        },
                        new
                        {
                            zonaID = new Guid("deb4cc83-aee1-4eac-a528-deb1784b80ea"),
                            brojZona = "zona4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
