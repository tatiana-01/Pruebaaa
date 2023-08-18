using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Automoviles",
                columns: table => new
                {
                    Id_Automovil = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Modelo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Año = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Capacidad = table.Column<int>(type: "int", nullable: false),
                    Precio_Diario = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automoviles", x => x.Id_Automovil);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id_Cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DNI = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id_Cliente);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id_Empleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DNI = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cargo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id_Empleado);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sucursales",
                columns: table => new
                {
                    Id_Sucursal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursales", x => x.Id_Sucursal);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Alquileres",
                columns: table => new
                {
                    Id_Alquiler = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Cliente = table.Column<int>(type: "int", nullable: false),
                    Id_Automovil = table.Column<int>(type: "int", nullable: false),
                    Fecha_Inicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Fecha_Fin = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Costo_Total = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alquileres", x => x.Id_Alquiler);
                    table.ForeignKey(
                        name: "FK_Alquileres_Automoviles_Id_Automovil",
                        column: x => x.Id_Automovil,
                        principalTable: "Automoviles",
                        principalColumn: "Id_Automovil",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alquileres_Clientes_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "Clientes",
                        principalColumn: "Id_Cliente",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    Id_Reserva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Cliente = table.Column<int>(type: "int", nullable: false),
                    Id_Automovil = table.Column<int>(type: "int", nullable: false),
                    Fecha_Reserva = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Fecha_Inicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Fecha_Fin = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.Id_Reserva);
                    table.ForeignKey(
                        name: "FK_Reservas_Automoviles_Id_Automovil",
                        column: x => x.Id_Automovil,
                        principalTable: "Automoviles",
                        principalColumn: "Id_Automovil",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservas_Clientes_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "Clientes",
                        principalColumn: "Id_Cliente",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SucursalAutomoviles",
                columns: table => new
                {
                    Id_Sucursal = table.Column<int>(type: "int", nullable: false),
                    Id_Automovil = table.Column<int>(type: "int", nullable: false),
                    SucursalId_Sucursal = table.Column<int>(type: "int", nullable: true),
                    AutomovilId_Automovil = table.Column<int>(type: "int", nullable: true),
                    Cantidad_Disponible = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SucursalAutomoviles", x => new { x.Id_Automovil, x.Id_Sucursal });
                    table.ForeignKey(
                        name: "FK_SucursalAutomoviles_Automoviles_AutomovilId_Automovil",
                        column: x => x.AutomovilId_Automovil,
                        principalTable: "Automoviles",
                        principalColumn: "Id_Automovil");
                    table.ForeignKey(
                        name: "FK_SucursalAutomoviles_Sucursales_SucursalId_Sucursal",
                        column: x => x.SucursalId_Sucursal,
                        principalTable: "Sucursales",
                        principalColumn: "Id_Sucursal");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Registro_Devoluciones",
                columns: table => new
                {
                    Id_Registro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Alquiler = table.Column<int>(type: "int", nullable: false),
                    Id_Empleado = table.Column<int>(type: "int", nullable: false),
                    Fecha_Devolucion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Combustible_Devuelto = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    Kilometraje_Devuelto = table.Column<int>(type: "int", nullable: false),
                    Monto_Adicional = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registro_Devoluciones", x => x.Id_Registro);
                    table.ForeignKey(
                        name: "FK_Registro_Devoluciones_Alquileres_Id_Alquiler",
                        column: x => x.Id_Alquiler,
                        principalTable: "Alquileres",
                        principalColumn: "Id_Alquiler",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registro_Devoluciones_Empleados_Id_Empleado",
                        column: x => x.Id_Empleado,
                        principalTable: "Empleados",
                        principalColumn: "Id_Empleado",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Registro_Entregas",
                columns: table => new
                {
                    Id_Registro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Alquiler = table.Column<int>(type: "int", nullable: false),
                    Id_Empleado = table.Column<int>(type: "int", nullable: false),
                    Fecha_Entrega = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Combustible_Entregado = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    Kilometraje_Entregado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registro_Entregas", x => x.Id_Registro);
                    table.ForeignKey(
                        name: "FK_Registro_Entregas_Alquileres_Id_Alquiler",
                        column: x => x.Id_Alquiler,
                        principalTable: "Alquileres",
                        principalColumn: "Id_Alquiler",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registro_Entregas_Empleados_Id_Empleado",
                        column: x => x.Id_Empleado,
                        principalTable: "Empleados",
                        principalColumn: "Id_Empleado",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Alquileres_Id_Automovil",
                table: "Alquileres",
                column: "Id_Automovil");

            migrationBuilder.CreateIndex(
                name: "IX_Alquileres_Id_Cliente",
                table: "Alquileres",
                column: "Id_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Registro_Devoluciones_Id_Alquiler",
                table: "Registro_Devoluciones",
                column: "Id_Alquiler");

            migrationBuilder.CreateIndex(
                name: "IX_Registro_Devoluciones_Id_Empleado",
                table: "Registro_Devoluciones",
                column: "Id_Empleado");

            migrationBuilder.CreateIndex(
                name: "IX_Registro_Entregas_Id_Alquiler",
                table: "Registro_Entregas",
                column: "Id_Alquiler");

            migrationBuilder.CreateIndex(
                name: "IX_Registro_Entregas_Id_Empleado",
                table: "Registro_Entregas",
                column: "Id_Empleado");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_Id_Automovil",
                table: "Reservas",
                column: "Id_Automovil");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_Id_Cliente",
                table: "Reservas",
                column: "Id_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_SucursalAutomoviles_AutomovilId_Automovil",
                table: "SucursalAutomoviles",
                column: "AutomovilId_Automovil");

            migrationBuilder.CreateIndex(
                name: "IX_SucursalAutomoviles_SucursalId_Sucursal",
                table: "SucursalAutomoviles",
                column: "SucursalId_Sucursal");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registro_Devoluciones");

            migrationBuilder.DropTable(
                name: "Registro_Entregas");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "SucursalAutomoviles");

            migrationBuilder.DropTable(
                name: "Alquileres");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Sucursales");

            migrationBuilder.DropTable(
                name: "Automoviles");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
