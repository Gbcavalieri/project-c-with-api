using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoadOfDreams.Migrations
{
    /// <inheritdoc />
    public partial class thirdmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Passagens",
                keyColumn: "id_passagens",
                keyValue: 1,
                columns: new[] { "agencia", "data_ida", "data_volta" },
                values: new object[] { "GOL", "27/07/2022", "27/07/2023" });

            migrationBuilder.UpdateData(
                table: "Passagens",
                keyColumn: "id_passagens",
                keyValue: 2,
                columns: new[] { "agencia", "destino", "data_ida", "quantidade_lugares", "data_volta" },
                values: new object[] { "AZUL", "Miami", "09/09/2021", "1", "01/01/2024" });

            migrationBuilder.UpdateData(
                table: "Passagens",
                keyColumn: "id_passagens",
                keyValue: 3,
                columns: new[] { "agencia", "destino", "data_ida", "quantidade_lugares", "data_volta" },
                values: new object[] { "EMIRATES", "Congo", "27/07/2022", "4", "27/08/2022" });

            migrationBuilder.UpdateData(
                table: "Passagens",
                keyColumn: "id_passagens",
                keyValue: 4,
                columns: new[] { "agencia", "destino", "data_ida", "origem", "data_volta" },
                values: new object[] { "GOL", "Emirados Árabes", "08/10/2019", "Rio de janeiro", "10/11/2025" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Passagens",
                keyColumn: "id_passagens",
                keyValue: 1,
                columns: new[] { "agencia", "data_ida", "data_volta" },
                values: new object[] { "Aquiraz", "27/07", "27/07" });

            migrationBuilder.UpdateData(
                table: "Passagens",
                keyColumn: "id_passagens",
                keyValue: 2,
                columns: new[] { "agencia", "destino", "data_ida", "quantidade_lugares", "data_volta" },
                values: new object[] { "Aquiraz", "Rio de Janeiro", "27/07", "2", "27/07" });

            migrationBuilder.UpdateData(
                table: "Passagens",
                keyColumn: "id_passagens",
                keyValue: 3,
                columns: new[] { "agencia", "destino", "data_ida", "quantidade_lugares", "data_volta" },
                values: new object[] { "Aquiraz", "Rio de Janeiro", "27/07", "2", "27/07" });

            migrationBuilder.UpdateData(
                table: "Passagens",
                keyColumn: "id_passagens",
                keyValue: 4,
                columns: new[] { "agencia", "destino", "data_ida", "origem", "data_volta" },
                values: new object[] { "Aquiraz", "Rio de Janeiro", "27/07", "São Paulo", "27/07" });
        }
    }
}
