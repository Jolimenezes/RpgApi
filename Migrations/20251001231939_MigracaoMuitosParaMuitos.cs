using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_HABILIDADES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGENS_HABILIDADES",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGENS_HABILIDADES", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADES_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADES",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 10, "Telecinesia" },
                    { 2, 20, "Confusão" },
                    { 3, 25, "Projeção" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 51, 68, 200, 55, 242, 42, 72, 70, 183, 219, 178, 21, 180, 109, 171, 39, 63, 24, 33, 95, 243, 194, 107, 160, 251, 16, 92, 161, 248, 8, 77, 87, 191, 168, 52, 115, 209, 185, 61, 143, 233, 164, 214, 209, 173, 0, 24, 96, 131, 190, 29, 129, 34, 49, 104, 23, 133, 250, 15, 23, 122, 160, 126, 31 }, new byte[] { 203, 27, 99, 137, 99, 5, 231, 111, 37, 28, 218, 171, 8, 197, 117, 76, 215, 97, 249, 124, 13, 94, 137, 140, 18, 156, 30, 0, 173, 37, 227, 202, 102, 38, 77, 23, 239, 163, 33, 61, 4, 130, 226, 77, 219, 240, 142, 169, 127, 31, 186, 234, 24, 67, 251, 208, 16, 77, 57, 206, 199, 214, 39, 158, 46, 113, 35, 80, 29, 187, 192, 50, 246, 84, 138, 206, 117, 96, 47, 43, 75, 193, 145, 200, 225, 210, 17, 232, 139, 73, 212, 42, 235, 102, 181, 144, 252, 223, 132, 151, 101, 68, 71, 202, 216, 112, 90, 138, 247, 114, 51, 80, 217, 123, 219, 115, 183, 238, 104, 32, 187, 186, 94, 231, 173, 119, 15, 155 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADES");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 102, 169, 165, 70, 184, 173, 249, 89, 151, 3, 189, 67, 147, 93, 170, 191, 240, 162, 73, 71, 125, 39, 178, 232, 31, 234, 194, 46, 203, 132, 243, 174, 215, 117, 1, 16, 174, 153, 167, 93, 118, 230, 2, 149, 63, 24, 203, 148, 57, 137, 137, 56, 155, 130, 81, 81, 245, 88, 160, 93, 125, 158, 153, 49 }, new byte[] { 194, 30, 94, 22, 19, 127, 246, 233, 148, 50, 18, 153, 213, 244, 35, 59, 46, 112, 123, 14, 76, 46, 208, 216, 24, 12, 143, 85, 103, 233, 246, 154, 211, 245, 113, 216, 47, 64, 47, 163, 122, 159, 111, 42, 21, 236, 57, 4, 240, 47, 174, 32, 227, 157, 167, 49, 7, 147, 229, 91, 249, 159, 194, 138, 103, 236, 123, 85, 182, 145, 159, 179, 246, 22, 205, 234, 33, 137, 205, 156, 61, 249, 122, 13, 99, 46, 247, 53, 104, 7, 161, 78, 0, 92, 223, 219, 103, 132, 69, 207, 159, 44, 187, 60, 12, 74, 193, 38, 116, 6, 178, 231, 41, 220, 135, 195, 143, 48, 7, 17, 234, 251, 72, 226, 155, 218, 121, 86 } });
        }
    }
}
