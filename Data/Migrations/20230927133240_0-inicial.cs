using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class _0inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    IdPost = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePost = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ResumoPost = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ConteudoPost = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    DataPost = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriador = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.IdPost);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
