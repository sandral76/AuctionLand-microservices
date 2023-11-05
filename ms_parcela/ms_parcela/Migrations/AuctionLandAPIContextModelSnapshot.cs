﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ms_parcela.Database;

#nullable disable

namespace msparcela.Migrations
{
    [DbContext(typeof(AuctionLandAPIContext))]
    partial class AuctionLandAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ms_parcela.Entities.DeoParceleE.DeoParcele", b =>
                {
                    b.Property<Guid>("deoParceleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("NadmetanjeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("brojKatastraskaOpstina")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("brojParcele")
                        .HasColumnType("int");

                    b.Property<int>("povrsinaDelaParcele")
                        .HasColumnType("int");

                    b.Property<int>("redniBrojDelaParcele")
                        .HasColumnType("int");

                    b.HasKey("deoParceleID");

                    b.ToTable("DeoParceles");

                    b.HasData(
                        new
                        {
                            deoParceleID = new Guid("68981084-b4a6-4564-bb69-7e2f24e5da8a"),
                            NadmetanjeId = new Guid("4f8fad5b-d9cb-469f-a165-70867728950e"),
                            brojKatastraskaOpstina = new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"),
                            brojParcele = 1,
                            povrsinaDelaParcele = 200,
                            redniBrojDelaParcele = 3,
                        },
                        new
                        {
                            deoParceleID = new Guid("765db74b-83ca-42d9-bc5b-9cd42b856382"),
                            NadmetanjeId = new Guid("528fad5b-d9cb-469f-a165-70867728950e"),
                            brojKatastraskaOpstina = new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"),
                            brojParcele = 1,
                            povrsinaDelaParcele = 200,
                            redniBrojDelaParcele = 4,
                        });
                });

            modelBuilder.Entity("ms_parcela.Entities.KatastarskaOpstina", b =>
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
                            brojKatastarskeOpstine = new Guid("a753ea75-c9ca-4ed6-bdf9-086669028d8d"),
                            nazivKatastarskeOpstine = "Cantavir"
                        },
                        new
                        {
                            brojKatastarskeOpstine = new Guid("92c9314c-6f9b-41c7-b0d5-4241887bc3d5"),
                            nazivKatastarskeOpstine = "Bajmok"
                        });
                });

            modelBuilder.Entity("ms_parcela.Entities.ParcelaE.Parcela", b =>
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

            modelBuilder.Entity("ms_parcela.Entities.Zona", b =>
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
                            zonaID = new Guid("3a64f694-e6de-4338-8b7a-f140c4004d6c"),
                            brojZona = "zona3"
                        },
                        new
                        {
                            zonaID = new Guid("3e3ac7f4-3f7f-470a-95d0-1bf84c2584af"),
                            brojZona = "zona4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
