using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class rahultest1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardPaymentDetail_enduser_UserId",
                table: "CardPaymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_useraddress_enduser_UserId",
                table: "useraddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_enduser",
                table: "enduser");

            migrationBuilder.RenameTable(
                name: "enduser",
                newName: "user");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user",
                table: "user",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CardPaymentDetail_user_UserId",
                table: "CardPaymentDetail",
                column: "UserId",
                principalTable: "user",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_useraddress_user_UserId",
                table: "useraddress",
                column: "UserId",
                principalTable: "user",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardPaymentDetail_user_UserId",
                table: "CardPaymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_useraddress_user_UserId",
                table: "useraddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user",
                table: "user");

            migrationBuilder.RenameTable(
                name: "user",
                newName: "enduser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_enduser",
                table: "enduser",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CardPaymentDetail_enduser_UserId",
                table: "CardPaymentDetail",
                column: "UserId",
                principalTable: "enduser",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_useraddress_enduser_UserId",
                table: "useraddress",
                column: "UserId",
                principalTable: "enduser",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
