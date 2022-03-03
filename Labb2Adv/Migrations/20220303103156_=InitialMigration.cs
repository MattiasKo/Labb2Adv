using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb2Adv.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kurs",
                columns: table => new
                {
                    KursId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LärId = table.Column<int>(nullable: false),
                    StudId = table.Column<int>(nullable: false),
                    KursNamn = table.Column<string>(nullable: true),
                    Betyg = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kurs", x => x.KursId);
                });

            migrationBuilder.CreateTable(
                name: "Linjes",
                columns: table => new
                {
                    LinjeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinjeNamn = table.Column<string>(nullable: true),
                    StudID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Linjes", x => x.LinjeId);
                });

            migrationBuilder.CreateTable(
                name: "Lärare",
                columns: table => new
                {
                    LärarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    EfterNamn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lärare", x => x.LärarId);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudName = table.Column<string>(nullable: true),
                    StudLname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kurs");

            migrationBuilder.DropTable(
                name: "Linjes");

            migrationBuilder.DropTable(
                name: "Lärare");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
