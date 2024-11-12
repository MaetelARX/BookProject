using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class addingRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        IF NOT EXISTS (SELECT 1 FROM AspNetRoles WHERE NormalizedName = 'USER')
        BEGIN
            INSERT INTO AspNetRoles (Id, Name, NormalizedName, ConcurrencyStamp)
            VALUES (NEWID(), 'User', 'USER', NEWID())
        END");

            migrationBuilder.Sql(@"
        IF NOT EXISTS (SELECT 1 FROM AspNetRoles WHERE NormalizedName = 'ADMIN')
        BEGIN
            INSERT INTO AspNetRoles (Id, Name, NormalizedName, ConcurrencyStamp)
            VALUES (NEWID(), 'Admin', 'ADMIN', NEWID())
        END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM AspNetRoles WHERE NormalizedName IN ('USER', 'ADMIN')");
        }
    }
}
