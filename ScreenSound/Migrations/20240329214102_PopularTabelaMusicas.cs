using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabelaMusicas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoDeLancamento" }, new object[] {"Sem Bala Contada", 2024});

            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoDeLancamento" }, new object[] { "Loucura", 2023 });

            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoDeLancamento" }, new object[] {"Chove Chuva", 2023 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM MUSICAS");
        }
    }
}
