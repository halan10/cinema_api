using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Place_of_birth = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Film_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Film_raiting = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Next_session = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Birthday", "Name", "Place_of_birth" },
                values: new object[,]
                {
                    { 1, new DateTime(1964, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Russell Crowe", "Wellington" },
                    { 2, new DateTime(1969, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matthew McConaughey", "Uvalde, Texas" },
                    { 3, new DateTime(1983, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexandre Rodrigues", "Rio de Janeiro" },
                    { 4, new DateTime(1974, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christian Bale", "Haverfordwest" }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "Description", "Film_name", "Film_raiting", "Next_session", "Price" },
                values: new object[,]
                {
                    { 1, "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the project and his team to disaster.", "Inception", 8.8000000000000007, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { 2, "The story of Henry Hill and his life in the mafia, covering his relationship with his wife Karen and his mob partners Jimmy Conway and Tommy DeVito.", "Goodfellas", 8.6999999999999993, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.0 },
                    { 3, "In the slums of Rio, two kids' paths diverge as one struggles to become a photographer and the other a kingpin.", "City of God", 8.5999999999999996, new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { 4, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "The Dark Knight", 9.0, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 170.0 },
                    { 5, "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.", "Gladiator", 8.5, new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Sessions");
        }
    }
}
