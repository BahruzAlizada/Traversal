using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_relation_destination_reservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DestinationnId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_DestinationnId",
                table: "Reservations",
                column: "DestinationnId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Destinations_DestinationnId",
                table: "Reservations",
                column: "DestinationnId",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Destinations_DestinationnId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_DestinationnId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "DestinationnId",
                table: "Reservations");
        }
    }
}
