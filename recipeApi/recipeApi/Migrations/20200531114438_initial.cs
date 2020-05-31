using Microsoft.EntityFrameworkCore.Migrations;

namespace recipeApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AmountTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmountTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ingrediens",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingrediens", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Recepies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recepies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RecepieIngrediens",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    amount = table.Column<int>(type: "int", nullable: false),
                    AmountTypeID = table.Column<int>(type: "int", nullable: true),
                    IngrediensID = table.Column<int>(type: "int", nullable: true),
                    RecepiesID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecepieIngrediens", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RecepieIngrediens_AmountTypes_AmountTypeID",
                        column: x => x.AmountTypeID,
                        principalTable: "AmountTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RecepieIngrediens_Ingrediens_IngrediensID",
                        column: x => x.IngrediensID,
                        principalTable: "Ingrediens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RecepieIngrediens_Recepies_RecepiesID",
                        column: x => x.RecepiesID,
                        principalTable: "Recepies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecepieIngrediens_AmountTypeID",
                table: "RecepieIngrediens",
                column: "AmountTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_RecepieIngrediens_IngrediensID",
                table: "RecepieIngrediens",
                column: "IngrediensID");

            migrationBuilder.CreateIndex(
                name: "IX_RecepieIngrediens_RecepiesID",
                table: "RecepieIngrediens",
                column: "RecepiesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecepieIngrediens");

            migrationBuilder.DropTable(
                name: "AmountTypes");

            migrationBuilder.DropTable(
                name: "Ingrediens");

            migrationBuilder.DropTable(
                name: "Recepies");
        }
    }
}
