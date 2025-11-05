using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 234, 47, 199, 130, 220, 60, 118, 195, 190, 63, 8, 113, 183, 142, 116, 117, 4, 9, 238, 218, 95, 122, 117, 185, 72, 25, 70, 116, 33, 244, 185, 129, 127, 36, 209, 1, 238, 210, 3, 25, 212, 43, 151, 48, 217, 200, 251, 110, 116, 138, 103, 4, 75, 56, 77, 252, 233, 201, 79, 30, 255, 145, 240, 151 }, new byte[] { 171, 29, 157, 0, 199, 153, 188, 72, 202, 176, 236, 96, 186, 83, 110, 236, 33, 109, 46, 164, 96, 246, 224, 169, 251, 105, 44, 18, 224, 52, 231, 172, 32, 219, 136, 217, 57, 193, 78, 38, 97, 243, 225, 219, 185, 229, 138, 40, 235, 255, 250, 38, 233, 84, 16, 140, 152, 88, 77, 141, 185, 72, 26, 14, 70, 37, 22, 140, 177, 209, 4, 248, 41, 239, 115, 117, 123, 219, 126, 180, 142, 194, 191, 151, 73, 60, 254, 123, 29, 131, 251, 91, 157, 11, 120, 5, 43, 206, 237, 105, 209, 66, 71, 117, 153, 226, 79, 201, 84, 70, 209, 10, 244, 116, 204, 1, 61, 81, 136, 206, 247, 87, 84, 52, 82, 66, 81, 217 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 171, 220, 171, 188, 251, 95, 132, 223, 239, 236, 252, 2, 255, 56, 34, 54, 63, 227, 178, 232, 202, 206, 26, 159, 54, 151, 97, 24, 37, 227, 50, 232, 202, 174, 222, 88, 203, 98, 115, 129, 98, 103, 150, 15, 57, 238, 144, 112, 184, 190, 3, 102, 31, 209, 228, 214, 252, 43, 85, 77, 153, 122, 201, 10 }, new byte[] { 195, 62, 75, 79, 32, 4, 7, 159, 53, 16, 87, 27, 142, 185, 19, 194, 218, 193, 52, 184, 109, 221, 21, 199, 107, 30, 4, 150, 98, 153, 132, 229, 155, 48, 152, 104, 99, 96, 245, 95, 167, 226, 12, 34, 171, 239, 54, 8, 91, 162, 98, 77, 10, 170, 163, 52, 232, 135, 79, 123, 130, 168, 144, 57, 157, 155, 152, 58, 253, 228, 139, 57, 61, 22, 61, 118, 228, 23, 47, 247, 211, 43, 98, 247, 130, 178, 88, 3, 50, 86, 51, 161, 245, 207, 18, 150, 38, 60, 215, 57, 128, 67, 18, 121, 14, 92, 93, 87, 209, 91, 27, 231, 8, 0, 135, 198, 185, 184, 218, 168, 44, 183, 98, 40, 177, 39, 97, 104 } });
        }
    }
}
