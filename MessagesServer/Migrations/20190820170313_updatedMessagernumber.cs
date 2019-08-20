using Microsoft.EntityFrameworkCore.Migrations;

namespace MessagesServer.Solution.Migrations
{
    public partial class updatedMessagernumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MessagerNumber",
                table: "messages",
                newName: "MessageNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MessageNumber",
                table: "messages",
                newName: "MessagerNumber");
        }
    }
}
