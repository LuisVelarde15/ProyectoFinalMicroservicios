// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiRentas.Helpers;

namespace WebApiRentas.Migrations
{
    [DbContext(typeof(Datos))]
    [Migration("20210828014637_Mr-01")]
    partial class Mr01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiRentas.Models.Rentas", b =>
                {
                    b.Property<int>("RentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaDevolucion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaRenta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PeliculaId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RentaId");

                    b.ToTable("Renta");
                });
#pragma warning restore 612, 618
        }
    }
}
