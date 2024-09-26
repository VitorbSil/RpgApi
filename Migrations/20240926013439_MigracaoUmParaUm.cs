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
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "TB_USUARIOS",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Perfil",
                table: "TB_USUARIOS",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "Jogador",
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValue: "Jogador");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "TB_PERSONAGENS",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

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

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "TB_ARMAS",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

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
                values: new object[] { new byte[] { 9, 23, 252, 169, 103, 148, 211, 106, 122, 37, 181, 187, 80, 80, 36, 79, 35, 235, 53, 119, 138, 254, 197, 182, 250, 134, 83, 62, 49, 13, 179, 128, 18, 127, 125, 63, 163, 233, 11, 166, 120, 76, 6, 116, 68, 249, 25, 17, 52, 228, 37, 164, 153, 217, 19, 78, 33, 245, 121, 129, 146, 171, 169, 189 }, new byte[] { 187, 147, 18, 3, 123, 234, 161, 142, 187, 140, 64, 166, 192, 22, 189, 40, 202, 184, 26, 95, 203, 169, 18, 29, 111, 211, 92, 199, 183, 18, 213, 211, 123, 146, 40, 24, 219, 130, 12, 25, 163, 157, 223, 96, 179, 20, 104, 105, 243, 223, 22, 116, 98, 184, 89, 92, 193, 185, 115, 234, 123, 205, 248, 245, 112, 155, 60, 69, 180, 119, 157, 217, 106, 228, 15, 87, 105, 123, 151, 203, 242, 218, 158, 182, 61, 58, 141, 96, 36, 32, 29, 59, 244, 107, 130, 98, 78, 175, 234, 154, 45, 67, 195, 212, 58, 179, 215, 146, 172, 20, 31, 184, 244, 211, 201, 244, 121, 248, 84, 76, 221, 218, 137, 229, 31, 50, 14, 168 } });

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

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "TB_USUARIOS",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Perfil",
                table: "TB_USUARIOS",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValue: "Jogador",
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200,
                oldDefaultValue: "Jogador");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "TB_PERSONAGENS",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "TB_ARMAS",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 228, 59, 215, 161, 249, 17, 175, 97, 211, 250, 7, 244, 111, 61, 200, 86, 210, 127, 215, 63, 203, 89, 116, 107, 133, 217, 29, 235, 202, 176, 21, 221, 52, 169, 238, 189, 203, 140, 193, 164, 4, 47, 130, 234, 5, 25, 150, 182, 187, 41, 41, 225, 133, 95, 229, 210, 104, 239, 172, 109, 88, 169, 95, 156 }, new byte[] { 214, 135, 121, 202, 216, 109, 10, 93, 48, 241, 45, 103, 129, 51, 18, 145, 160, 179, 82, 116, 192, 79, 107, 173, 230, 104, 70, 37, 151, 46, 243, 108, 12, 228, 1, 106, 192, 170, 0, 247, 107, 190, 100, 215, 169, 229, 39, 21, 210, 127, 244, 126, 59, 115, 55, 134, 103, 107, 233, 210, 132, 156, 179, 247, 52, 218, 243, 206, 113, 116, 27, 10, 87, 138, 59, 47, 241, 48, 12, 218, 108, 214, 138, 197, 217, 92, 161, 13, 33, 36, 41, 108, 16, 238, 246, 252, 9, 215, 109, 19, 88, 30, 221, 214, 33, 28, 145, 22, 193, 35, 11, 214, 120, 236, 28, 133, 12, 149, 238, 72, 76, 148, 42, 210, 114, 0, 247, 169 } });
        }
    }
}
