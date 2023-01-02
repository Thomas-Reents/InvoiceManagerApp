using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityApp.Data.Migrations
{
    public partial class fixedMinthToMonth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InvoiceMinth",
                table: "Invoice",
                newName: "InvoiceMonth");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InvoiceMonth",
                table: "Invoice",
                newName: "InvoiceMonth");
        }
    }
}
