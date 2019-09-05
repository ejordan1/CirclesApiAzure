using Microsoft.EntityFrameworkCore.Migrations;

namespace MessagesServer.Solution.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(nullable: true),
                    MessageText = table.Column<string>(nullable: true),
                    MessageNumber = table.Column<int>(nullable: false),
                    MessageNote = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messages", x => x.MessageId);
                });

            migrationBuilder.CreateTable(
                name: "messages2",
                columns: table => new
                {
                    MessageId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(nullable: true),
                    MessageText = table.Column<string>(nullable: true),
                    MessageNumber = table.Column<int>(nullable: false),
                    MessageNote = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messages2", x => x.MessageId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "messages");

            migrationBuilder.DropTable(
                name: "messages2");
        }
    }
}
