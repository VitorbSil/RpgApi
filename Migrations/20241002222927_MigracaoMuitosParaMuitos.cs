﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 70, 21, 150, 104, 247, 184, 147, 153, 204, 6, 101, 106, 58, 110, 63, 227, 36, 146, 113, 35, 176, 22, 216, 196, 155, 220, 21, 210, 13, 133, 43, 161, 114, 61, 110, 239, 228, 48, 66, 196, 38, 73, 91, 144, 48, 245, 172, 119, 109, 234, 193, 228, 126, 203, 189, 94, 251, 148, 114, 194, 169, 128, 13, 17 }, new byte[] { 37, 47, 213, 91, 94, 128, 79, 142, 67, 135, 56, 176, 69, 113, 182, 163, 211, 140, 176, 229, 113, 93, 245, 103, 184, 5, 21, 103, 202, 41, 80, 26, 248, 124, 210, 119, 232, 66, 19, 46, 225, 183, 2, 48, 104, 53, 109, 23, 180, 208, 175, 43, 5, 23, 183, 130, 227, 141, 118, 148, 48, 173, 190, 141, 31, 115, 73, 86, 127, 192, 213, 145, 197, 146, 63, 111, 199, 121, 57, 252, 121, 40, 208, 189, 55, 197, 33, 123, 187, 15, 166, 197, 76, 194, 82, 37, 167, 182, 143, 209, 179, 34, 220, 154, 18, 245, 47, 102, 168, 127, 13, 252, 31, 6, 217, 163, 241, 144, 38, 170, 249, 153, 142, 69, 159, 20, 48, 6 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 9, 23, 252, 169, 103, 148, 211, 106, 122, 37, 181, 187, 80, 80, 36, 79, 35, 235, 53, 119, 138, 254, 197, 182, 250, 134, 83, 62, 49, 13, 179, 128, 18, 127, 125, 63, 163, 233, 11, 166, 120, 76, 6, 116, 68, 249, 25, 17, 52, 228, 37, 164, 153, 217, 19, 78, 33, 245, 121, 129, 146, 171, 169, 189 }, new byte[] { 187, 147, 18, 3, 123, 234, 161, 142, 187, 140, 64, 166, 192, 22, 189, 40, 202, 184, 26, 95, 203, 169, 18, 29, 111, 211, 92, 199, 183, 18, 213, 211, 123, 146, 40, 24, 219, 130, 12, 25, 163, 157, 223, 96, 179, 20, 104, 105, 243, 223, 22, 116, 98, 184, 89, 92, 193, 185, 115, 234, 123, 205, 248, 245, 112, 155, 60, 69, 180, 119, 157, 217, 106, 228, 15, 87, 105, 123, 151, 203, 242, 218, 158, 182, 61, 58, 141, 96, 36, 32, 29, 59, 244, 107, 130, 98, 78, 175, 234, 154, 45, 67, 195, 212, 58, 179, 215, 146, 172, 20, 31, 184, 244, 211, 201, 244, 121, 248, 84, 76, 221, 218, 137, 229, 31, 50, 14, 168 } });
        }
    }
}
