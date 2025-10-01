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
                values: new object[] { new byte[] { 102, 169, 165, 70, 184, 173, 249, 89, 151, 3, 189, 67, 147, 93, 170, 191, 240, 162, 73, 71, 125, 39, 178, 232, 31, 234, 194, 46, 203, 132, 243, 174, 215, 117, 1, 16, 174, 153, 167, 93, 118, 230, 2, 149, 63, 24, 203, 148, 57, 137, 137, 56, 155, 130, 81, 81, 245, 88, 160, 93, 125, 158, 153, 49 }, new byte[] { 194, 30, 94, 22, 19, 127, 246, 233, 148, 50, 18, 153, 213, 244, 35, 59, 46, 112, 123, 14, 76, 46, 208, 216, 24, 12, 143, 85, 103, 233, 246, 154, 211, 245, 113, 216, 47, 64, 47, 163, 122, 159, 111, 42, 21, 236, 57, 4, 240, 47, 174, 32, 227, 157, 167, 49, 7, 147, 229, 91, 249, 159, 194, 138, 103, 236, 123, 85, 182, 145, 159, 179, 246, 22, 205, 234, 33, 137, 205, 156, 61, 249, 122, 13, 99, 46, 247, 53, 104, 7, 161, 78, 0, 92, 223, 219, 103, 132, 69, 207, 159, 44, 187, 60, 12, 74, 193, 38, 116, 6, 178, 231, 41, 220, 135, 195, 143, 48, 7, 17, 234, 251, 72, 226, 155, 218, 121, 86 } });

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
                values: new object[] { new byte[] { 195, 56, 92, 32, 132, 247, 94, 78, 201, 89, 17, 96, 160, 46, 17, 253, 74, 17, 79, 47, 152, 219, 2, 208, 250, 132, 182, 78, 8, 78, 41, 20, 82, 214, 80, 203, 241, 178, 199, 213, 167, 172, 206, 194, 181, 167, 211, 204, 169, 152, 145, 71, 115, 183, 197, 18, 146, 111, 42, 116, 49, 161, 229, 163 }, new byte[] { 113, 77, 82, 139, 150, 247, 11, 95, 145, 221, 226, 175, 206, 71, 38, 175, 150, 115, 223, 17, 37, 139, 196, 17, 188, 13, 190, 226, 107, 11, 205, 99, 202, 125, 192, 94, 78, 132, 93, 235, 37, 167, 25, 43, 199, 72, 45, 0, 100, 4, 208, 15, 75, 32, 135, 9, 181, 254, 130, 88, 82, 205, 199, 38, 31, 114, 91, 73, 14, 37, 176, 123, 129, 75, 78, 178, 38, 109, 234, 113, 29, 179, 195, 55, 68, 252, 63, 122, 223, 204, 149, 106, 252, 237, 74, 126, 29, 179, 200, 32, 86, 240, 59, 110, 137, 69, 17, 129, 179, 53, 67, 66, 117, 109, 80, 205, 168, 187, 156, 211, 175, 235, 196, 160, 20, 233, 17, 247 } });
        }
    }
}
