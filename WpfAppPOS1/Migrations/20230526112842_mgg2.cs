﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfAppPOS1.Migrations
{
    /// <inheritdoc />
    public partial class mgg2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 91, 83, 240, 33, 84, 155, 164, 198, 166, 55, 61, 44, 52, 208, 125, 175, 34, 225, 214, 90, 87, 228, 139, 124, 202, 179, 226, 64, 29, 188, 166, 128, 18, 34, 43, 66, 121, 67, 75, 27, 213, 39, 45, 153, 21, 86, 202, 189, 208, 241, 1, 82, 37, 181, 106, 159, 19, 132, 17, 151, 157, 45, 64, 171 }, new byte[] { 231, 49, 211, 69, 159, 255, 159, 27, 228, 63, 2, 50, 243, 25, 43, 173, 82, 197, 163, 35, 57, 219, 26, 253, 27, 19, 105, 126, 253, 82, 104, 170, 216, 71, 13, 86, 47, 213, 18, 111, 195, 51, 122, 75, 71, 170, 170, 204, 142, 152, 246, 69, 56, 127, 98, 111, 209, 43, 107, 80, 27, 68, 23, 3, 86, 221, 7, 143, 114, 181, 250, 201, 48, 141, 107, 154, 47, 184, 142, 127, 69, 227, 81, 160, 215, 63, 120, 100, 144, 104, 156, 226, 215, 74, 127, 129, 79, 228, 105, 116, 175, 220, 144, 141, 160, 167, 87, 63, 27, 163, 116, 225, 65, 240, 213, 231, 49, 7, 239, 21, 30, 111, 71, 54, 79, 28, 132, 142 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 76, 229, 211, 54, 184, 78, 168, 35, 38, 94, 173, 189, 0, 156, 161, 131, 222, 210, 116, 109, 50, 228, 173, 109, 95, 191, 41, 163, 221, 173, 207, 179, 212, 31, 12, 58, 21, 1, 173, 55, 173, 41, 21, 138, 229, 121, 85, 23, 64, 211, 119, 110, 32, 66, 99, 92, 21, 158, 176, 83, 17, 30, 204, 166 }, new byte[] { 226, 22, 225, 138, 152, 162, 184, 43, 37, 209, 130, 212, 53, 99, 142, 196, 165, 232, 239, 150, 255, 49, 146, 44, 18, 86, 66, 252, 153, 73, 102, 235, 124, 6, 227, 71, 77, 113, 7, 73, 224, 172, 13, 111, 64, 173, 110, 0, 76, 177, 219, 116, 215, 160, 2, 216, 12, 71, 163, 203, 139, 203, 175, 158, 225, 17, 132, 245, 107, 169, 182, 203, 184, 0, 188, 162, 233, 134, 138, 90, 90, 164, 174, 231, 37, 67, 61, 211, 98, 20, 185, 111, 178, 148, 86, 34, 245, 190, 173, 127, 121, 173, 63, 97, 24, 0, 76, 86, 65, 190, 103, 187, 18, 139, 8, 103, 85, 4, 213, 27, 6, 71, 167, 124, 98, 165, 249, 68 } });
        }
    }
}
