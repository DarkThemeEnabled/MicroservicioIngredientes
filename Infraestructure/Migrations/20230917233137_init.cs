using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TiposIngrediente",
                columns: table => new
                {
                    TipoIngredienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposIngrediente", x => x.TipoIngredienteID);
                });

            migrationBuilder.CreateTable(
                name: "TiposMedida",
                columns: table => new
                {
                    TipoMedidaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposMedida", x => x.TipoMedidaID);
                });

            migrationBuilder.CreateTable(
                name: "Ingredientes",
                columns: table => new
                {
                    IngredienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoIngredienteID = table.Column<int>(type: "int", nullable: false),
                    TipoMedidaID = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredientes", x => x.IngredienteID);
                    table.ForeignKey(
                        name: "FK_Ingredientes_TiposIngrediente_TipoIngredienteID",
                        column: x => x.TipoIngredienteID,
                        principalTable: "TiposIngrediente",
                        principalColumn: "TipoIngredienteID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ingredientes_TiposMedida_TipoMedidaID",
                        column: x => x.TipoMedidaID,
                        principalTable: "TiposMedida",
                        principalColumn: "TipoMedidaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TiposIngrediente",
                columns: new[] { "TipoIngredienteID", "Nombre" },
                values: new object[,]
                {
                    { 1, "Vegetal" },
                    { 2, "Lacteo" },
                    { 3, "Carne" },
                    { 4, "Especia" }
                });

            migrationBuilder.InsertData(
                table: "TiposMedida",
                columns: new[] { "TipoMedidaID", "Nombre" },
                values: new object[,]
                {
                    { 1, "Gramo" },
                    { 2, "Litro" },
                    { 3, "Unidad" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredientes_TipoIngredienteID",
                table: "Ingredientes",
                column: "TipoIngredienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredientes_TipoMedidaID",
                table: "Ingredientes",
                column: "TipoMedidaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredientes");

            migrationBuilder.DropTable(
                name: "TiposIngrediente");

            migrationBuilder.DropTable(
                name: "TiposMedida");
        }
    }
}
