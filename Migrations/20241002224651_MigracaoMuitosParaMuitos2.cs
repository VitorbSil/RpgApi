using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos2 : Migration
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
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 43, 97, 243, 75, 133, 20, 39, 227, 150, 48, 127, 178, 194, 181, 138, 138, 2, 43, 75, 248, 232, 19, 9, 170, 153, 157, 7, 155, 165, 206, 124, 83, 28, 179, 129, 96, 218, 27, 218, 40, 13, 9, 43, 22, 132, 145, 211, 8, 66, 115, 246, 173, 76, 16, 247, 165, 255, 203, 126, 203, 177, 130, 39, 163 }, new byte[] { 90, 165, 243, 38, 35, 99, 33, 88, 77, 31, 161, 192, 124, 248, 187, 159, 35, 239, 2, 143, 213, 122, 160, 54, 159, 152, 228, 149, 193, 215, 159, 71, 173, 147, 53, 33, 116, 229, 219, 204, 8, 184, 55, 96, 154, 137, 205, 209, 166, 72, 147, 190, 77, 130, 192, 168, 16, 231, 168, 48, 74, 239, 236, 68, 108, 10, 133, 67, 169, 241, 67, 181, 18, 145, 187, 134, 68, 214, 86, 37, 90, 40, 183, 87, 88, 139, 207, 35, 152, 233, 56, 233, 156, 133, 32, 5, 60, 195, 76, 111, 173, 3, 104, 194, 241, 40, 194, 111, 202, 210, 175, 105, 75, 177, 11, 140, 27, 21, 72, 135, 112, 144, 107, 207, 175, 235, 89, 148 } });

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
                values: new object[] { new byte[] { 70, 21, 150, 104, 247, 184, 147, 153, 204, 6, 101, 106, 58, 110, 63, 227, 36, 146, 113, 35, 176, 22, 216, 196, 155, 220, 21, 210, 13, 133, 43, 161, 114, 61, 110, 239, 228, 48, 66, 196, 38, 73, 91, 144, 48, 245, 172, 119, 109, 234, 193, 228, 126, 203, 189, 94, 251, 148, 114, 194, 169, 128, 13, 17 }, new byte[] { 37, 47, 213, 91, 94, 128, 79, 142, 67, 135, 56, 176, 69, 113, 182, 163, 211, 140, 176, 229, 113, 93, 245, 103, 184, 5, 21, 103, 202, 41, 80, 26, 248, 124, 210, 119, 232, 66, 19, 46, 225, 183, 2, 48, 104, 53, 109, 23, 180, 208, 175, 43, 5, 23, 183, 130, 227, 141, 118, 148, 48, 173, 190, 141, 31, 115, 73, 86, 127, 192, 213, 145, 197, 146, 63, 111, 199, 121, 57, 252, 121, 40, 208, 189, 55, 197, 33, 123, 187, 15, 166, 197, 76, 194, 82, 37, 167, 182, 143, 209, 179, 34, 220, 154, 18, 245, 47, 102, 168, 127, 13, 252, 31, 6, 217, 163, 241, 144, 38, 170, 249, 153, 142, 69, 159, 20, 48, 6 } });
        }
    }
}
