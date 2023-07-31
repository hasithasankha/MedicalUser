using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalUser.Migrations
{
    public partial class adding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    APPOI_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Appointment_List = table.Column<string>(nullable: false),
                    CusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.APPOI_Id);
                    table.ForeignKey(
                        name: "FK_Appointment_Customer_CusId",
                        column: x => x.CusId,
                        principalTable: "Customer",
                        principalColumn: "CusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_CusId",
                table: "Appointment",
                column: "CusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointment");
        }
    }
}
