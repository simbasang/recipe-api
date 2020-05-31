using Microsoft.EntityFrameworkCore.Migrations;

namespace recipeApi.Migrations
{
    public partial class exData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecepieIngrediens_AmountTypes_AmountTypeID",
                table: "RecepieIngrediens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AmountTypes",
                table: "AmountTypes");

            migrationBuilder.RenameTable(
                name: "AmountTypes",
                newName: "AmountType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AmountType",
                table: "AmountType",
                column: "ID");

            migrationBuilder.InsertData(
                table: "AmountType",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "dl" },
                    { 2, "msk" },
                    { 3, "tsk" },
                    { 4, "gram" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_RecepieIngrediens_AmountType_AmountTypeID",
                table: "RecepieIngrediens",
                column: "AmountTypeID",
                principalTable: "AmountType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecepieIngrediens_AmountType_AmountTypeID",
                table: "RecepieIngrediens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AmountType",
                table: "AmountType");

            migrationBuilder.DeleteData(
                table: "AmountType",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AmountType",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AmountType",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AmountType",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "AmountType",
                newName: "AmountTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AmountTypes",
                table: "AmountTypes",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_RecepieIngrediens_AmountTypes_AmountTypeID",
                table: "RecepieIngrediens",
                column: "AmountTypeID",
                principalTable: "AmountTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
