using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reactivities.Persistance.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Venue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("0a70036a-e2fe-4fcb-9fba-a6af8cb0dc54"), "drinks", "London", new DateTime(2023, 1, 14, 16, 31, 43, 84, DateTimeKind.Local).AddTicks(3442), "Activity 5 months in future", "Future Activity 5", "Just another pub" },
                    { new Guid("3f91340d-6214-4200-9312-21cd60654fd2"), "culture", "Paris", new DateTime(2022, 7, 14, 16, 31, 43, 84, DateTimeKind.Local).AddTicks(3420), "Activity 1 month ago", "Past Activity 2", "Louvre" },
                    { new Guid("440b8ad0-5b40-4805-a7b2-52d04d670beb"), "drinks", "London", new DateTime(2022, 11, 14, 16, 31, 43, 84, DateTimeKind.Local).AddTicks(3431), "Activity 3 months in future", "Future Activity 3", "Another pub" },
                    { new Guid("727fcebe-800f-4b0b-bffc-c53b215f3e9b"), "drinks", "London", new DateTime(2022, 6, 14, 16, 31, 43, 84, DateTimeKind.Local).AddTicks(3374), "Activity 2 months ago", "Past Activity 1", "Pub" },
                    { new Guid("74c44b38-57a1-4f40-ae59-ae1d1597f64f"), "drinks", "London", new DateTime(2022, 12, 14, 16, 31, 43, 84, DateTimeKind.Local).AddTicks(3439), "Activity 4 months in future", "Future Activity 4", "Yet another pub" },
                    { new Guid("7668de5d-2fed-421f-b553-7d69c5715998"), "music", "London", new DateTime(2023, 2, 14, 16, 31, 43, 84, DateTimeKind.Local).AddTicks(3446), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("9018b4b6-4347-4f33-a3ac-8fbc2b89f1ce"), "travel", "London", new DateTime(2023, 3, 14, 16, 31, 43, 84, DateTimeKind.Local).AddTicks(3450), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" },
                    { new Guid("945fd28d-abdb-48cd-8c39-dc0192578bc8"), "culture", "London", new DateTime(2022, 9, 14, 16, 31, 43, 84, DateTimeKind.Local).AddTicks(3425), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { new Guid("b6974c66-23cb-4980-84ef-197f7eb9776f"), "music", "London", new DateTime(2022, 10, 14, 16, 31, 43, 84, DateTimeKind.Local).AddTicks(3428), "Activity 2 months in future", "Future Activity 2", "O2 Arena" },
                    { new Guid("dd07fe2e-7e2e-4dd7-9fae-9faad6f96815"), "film", "London", new DateTime(2023, 4, 14, 16, 31, 43, 84, DateTimeKind.Local).AddTicks(3453), "Activity 8 months in future", "Future Activity 8", "Cinema" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");
        }
    }
}
