using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class mig_add_relation_service_reservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiceID",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ServiceID",
                table: "Reservations",
                column: "ServiceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Services_ServiceID",
                table: "Reservations",
                column: "ServiceID",
                principalTable: "Services",
                principalColumn: "ServiceID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Services_ServiceID",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ServiceID",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ServiceID",
                table: "Reservations");
        }
    }
}
