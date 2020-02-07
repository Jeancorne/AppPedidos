using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPedidos.Migrations
{
    public partial class Iniciar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblClientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCliente = table.Column<string>(maxLength: 70, nullable: false),
                    ApellidoCliente = table.Column<string>(maxLength: 70, nullable: false),
                    CedulaCliente = table.Column<int>(nullable: false),
                    EmailCliente = table.Column<string>(maxLength: 70, nullable: false),
                    TelefonoCliente = table.Column<int>(nullable: false),
                    DireccionCliente = table.Column<string>(maxLength: 150, nullable: false),
                    Ciudad = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblClientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "tblProducto",
                columns: table => new
                {
                    IdProducto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PluProducto = table.Column<int>(nullable: false),
                    NombreProducto = table.Column<string>(maxLength: 300, nullable: true),
                    DescripcionProducto = table.Column<string>(maxLength: 500, nullable: false),
                    MarcaProducto = table.Column<string>(maxLength: 100, nullable: false),
                    CantidadDisponible = table.Column<int>(nullable: false),
                    ValorProducto = table.Column<float>(nullable: false),
                    IvaProducto = table.Column<float>(nullable: false),
                    ObservacionProducto = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProducto", x => x.IdProducto);
                });

            migrationBuilder.CreateTable(
                name: "tblPedido",
                columns: table => new
                {
                    IdPedido = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreRecibe = table.Column<string>(maxLength: 100, nullable: false),
                    ObservacionGeneral = table.Column<string>(maxLength: 300, nullable: false),
                    TotalProductos = table.Column<int>(nullable: false),
                    ValorTotalPedido = table.Column<int>(nullable: false),
                    IdCliente = table.Column<int>(nullable: false),
                    IdProducto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPedido", x => x.IdPedido);
                    table.ForeignKey(
                        name: "FK_tblPedido_tblClientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "tblClientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblPedido_tblProducto_IdProducto",
                        column: x => x.IdProducto,
                        principalTable: "tblProducto",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblPedido_IdCliente",
                table: "tblPedido",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_tblPedido_IdProducto",
                table: "tblPedido",
                column: "IdProducto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblPedido");

            migrationBuilder.DropTable(
                name: "tblClientes");

            migrationBuilder.DropTable(
                name: "tblProducto");
        }
    }
}
