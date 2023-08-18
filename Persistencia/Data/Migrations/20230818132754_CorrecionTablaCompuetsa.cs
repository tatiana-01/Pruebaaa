using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class CorrecionTablaCompuetsa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SucursalAutomoviles_Automoviles_AutomovilId_Automovil",
                table: "SucursalAutomoviles");

            migrationBuilder.DropForeignKey(
                name: "FK_SucursalAutomoviles_Sucursales_SucursalId_Sucursal",
                table: "SucursalAutomoviles");

            migrationBuilder.DropIndex(
                name: "IX_SucursalAutomoviles_AutomovilId_Automovil",
                table: "SucursalAutomoviles");

            migrationBuilder.DropIndex(
                name: "IX_SucursalAutomoviles_SucursalId_Sucursal",
                table: "SucursalAutomoviles");

            migrationBuilder.DropColumn(
                name: "AutomovilId_Automovil",
                table: "SucursalAutomoviles");

            migrationBuilder.DropColumn(
                name: "SucursalId_Sucursal",
                table: "SucursalAutomoviles");

            migrationBuilder.CreateIndex(
                name: "IX_SucursalAutomoviles_Id_Sucursal",
                table: "SucursalAutomoviles",
                column: "Id_Sucursal");

            migrationBuilder.AddForeignKey(
                name: "FK_SucursalAutomoviles_Automoviles_Id_Automovil",
                table: "SucursalAutomoviles",
                column: "Id_Automovil",
                principalTable: "Automoviles",
                principalColumn: "Id_Automovil",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SucursalAutomoviles_Sucursales_Id_Sucursal",
                table: "SucursalAutomoviles",
                column: "Id_Sucursal",
                principalTable: "Sucursales",
                principalColumn: "Id_Sucursal",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SucursalAutomoviles_Automoviles_Id_Automovil",
                table: "SucursalAutomoviles");

            migrationBuilder.DropForeignKey(
                name: "FK_SucursalAutomoviles_Sucursales_Id_Sucursal",
                table: "SucursalAutomoviles");

            migrationBuilder.DropIndex(
                name: "IX_SucursalAutomoviles_Id_Sucursal",
                table: "SucursalAutomoviles");

            migrationBuilder.AddColumn<int>(
                name: "AutomovilId_Automovil",
                table: "SucursalAutomoviles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SucursalId_Sucursal",
                table: "SucursalAutomoviles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SucursalAutomoviles_AutomovilId_Automovil",
                table: "SucursalAutomoviles",
                column: "AutomovilId_Automovil");

            migrationBuilder.CreateIndex(
                name: "IX_SucursalAutomoviles_SucursalId_Sucursal",
                table: "SucursalAutomoviles",
                column: "SucursalId_Sucursal");

            migrationBuilder.AddForeignKey(
                name: "FK_SucursalAutomoviles_Automoviles_AutomovilId_Automovil",
                table: "SucursalAutomoviles",
                column: "AutomovilId_Automovil",
                principalTable: "Automoviles",
                principalColumn: "Id_Automovil");

            migrationBuilder.AddForeignKey(
                name: "FK_SucursalAutomoviles_Sucursales_SucursalId_Sucursal",
                table: "SucursalAutomoviles",
                column: "SucursalId_Sucursal",
                principalTable: "Sucursales",
                principalColumn: "Id_Sucursal");
        }
    }
}
