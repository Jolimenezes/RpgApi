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
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 193, 242, 158, 43, 96, 61, 142, 94, 91, 103, 232, 98, 12, 126, 214, 226, 233, 176, 156, 225, 21, 130, 136, 180, 205, 75, 36, 6, 132, 220, 59, 177, 255, 50, 60, 178, 243, 96, 136, 110, 94, 81, 113, 175, 76, 135, 228, 163, 86, 98, 43, 195, 212, 111, 238, 77, 136, 235, 244, 12, 3, 156, 211 }, new byte[] { 156, 68, 99, 226, 211, 205, 29, 74, 254, 121, 42, 168, 152, 177, 230, 40, 132, 126, 159, 163, 249, 129, 15, 17, 124, 143, 143, 133, 245, 228, 128, 128, 33, 62, 37, 186, 209, 150, 212, 45, 248, 16, 168, 230, 71, 121, 69, 47, 139, 167, 241, 120, 219, 53, 199, 173, 62, 84, 108, 167, 225, 182, 94, 95, 115, 98, 254, 100, 129, 187, 43, 103, 177, 148, 107, 214, 161, 201, 243, 18, 73, 148, 242, 8, 134, 0, 19, 240, 71, 166, 216, 67, 220, 76, 198, 25, 83, 230, 118, 240, 246, 202, 25, 127, 186, 126, 172, 49, 209, 29, 251, 205, 173, 121, 57, 72, 181, 31, 64, 201, 84, 14, 41, 132, 229, 217, 48, 209 } });

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
                values: new object[] { new byte[] { 234, 47, 199, 130, 220, 60, 118, 195, 190, 63, 8, 113, 183, 142, 116, 117, 4, 9, 238, 218, 95, 122, 117, 185, 72, 25, 70, 116, 33, 244, 185, 129, 127, 36, 209, 1, 238, 210, 3, 25, 212, 43, 151, 48, 217, 200, 251, 110, 116, 138, 103, 4, 75, 56, 77, 252, 233, 201, 79, 30, 255, 145, 240, 151 }, new byte[] { 171, 29, 157, 0, 199, 153, 188, 72, 202, 176, 236, 96, 186, 83, 110, 236, 33, 109, 46, 164, 96, 246, 224, 169, 251, 105, 44, 18, 224, 52, 231, 172, 32, 219, 136, 217, 57, 193, 78, 38, 97, 243, 225, 219, 185, 229, 138, 40, 235, 255, 250, 38, 233, 84, 16, 140, 152, 88, 77, 141, 185, 72, 26, 14, 70, 37, 22, 140, 177, 209, 4, 248, 41, 239, 115, 117, 123, 219, 126, 180, 142, 194, 191, 151, 73, 60, 254, 123, 29, 131, 251, 91, 157, 11, 120, 5, 43, 206, 237, 105, 209, 66, 71, 117, 153, 226, 79, 201, 84, 70, 209, 10, 244, 116, 204, 1, 61, 81, 136, 206, 247, 87, 84, 52, 82, 66, 81, 217 } });
        }
    }
}
