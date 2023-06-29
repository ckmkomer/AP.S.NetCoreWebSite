using Microsoft.EntityFrameworkCore.Migrations;

namespace Core_Proje_Api.Migrations
{
    public partial class migy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.CreateTable(
                name: "yCategories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yCategories", x => x.CategoryID);
                });
        }

       
        }
    }
  
