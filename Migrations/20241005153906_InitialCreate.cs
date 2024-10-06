using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SimplyBooksAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Favorite = table.Column<bool>(type: "boolean", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AuthorId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Sale = table.Column<bool>(type: "boolean", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Email", "Favorite", "FirstName", "Image", "LastName", "UserId" },
                values: new object[,]
                {
                    { 1, "ta@ta.com", false, "Tomi", "https://upload.wikimedia.org/wikipedia/commons/1/17/Tomi_Adeyemi_2020.JPG", "Adeyemi", "1007" },
                    { 2, "ba@obama.com", false, "Barack", "https://upload.wikimedia.org/wikipedia/commons/8/8d/President_Barack_Obama.jpg", "Obama", "1007" },
                    { 3, "hz@zinn.com", false, "Howard", "https://upload.wikimedia.org/wikipedia/commons/e/ef/Howard_Zinn%2C_2009_%28cropped%29.jpg", "Zinn", "1007" },
                    { 4, "at@thomas.com", false, "Angie", "https://upload.wikimedia.org/wikipedia/commons/a/a1/Angie_thomas_9022008.jpg", "Thomas", "1007" },
                    { 5, "cw@whithead.com", false, "Colson", "https://upload.wikimedia.org/wikipedia/commons/5/5c/Colson_Whitehead_BBF_2011_Shankbone.JPG", "Whitehead", "1007" },
                    { 6, "mk@kendall.com", false, "Mikki", "https://upload.wikimedia.org/wikipedia/commons/1/17/Author%2C_activist%2C_and_cultural_critic_Mikki_Kendall.jpg", "Kendall", "1007" },
                    { 7, "lm@lm.com", false, "L.L", "https://mpd-biblio-authors.imgix.net/200066919.jpg?fit=crop&crop=faces&w=870&h=870", "McKinney", "1007" },
                    { 8, "jb@baldwin.com", false, "James", "https://upload.wikimedia.org/wikipedia/commons/3/37/James_Baldwin_33_Allan_Warren.jpg", "Baldwin", "1007" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { "1007", "Zach", "Colburn" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Image", "Price", "Sale", "Title", "UserId" },
                values: new object[,]
                {
                    { 101, 1, "", "https://images-na.ssl-images-amazon.com/images/I/91+NBrXG-PL.jpg", 24.99m, false, "A Promised Land", "1007" },
                    { 102, 2, "", "https://images-na.ssl-images-amazon.com/images/I/A1agLFsWkOL.jpg", 12.99m, true, "Children of Blood and Bone", "1007" },
                    { 103, 3, "", "https://images-na.ssl-images-amazon.com/images/I/51529Lfc2ML.jpg", 30.00m, false, "A People's History of the United States of America", "1007" },
                    { 104, 4, "", "https://images-na.ssl-images-amazon.com/images/I/81rRRmZZvZL.jpg", 15.89m, false, "Concrete Rose", "1007" },
                    { 105, 5, "", "https://images-na.ssl-images-amazon.com/images/I/A1Cu4ywUeyL.jpg", 25.00m, true, "The Underground Railroad", "1007" },
                    { 106, 6, "", "https://res.cloudinary.com/bloomsbury-atlas/image/upload/w_360,c_scale/jackets/9781526622402.jpg", 12.99m, true, "Hood Feminism", "1007" },
                    { 107, 7, "", "https://images-na.ssl-images-amazon.com/images/I/81Uf1dTjfQL.jpg", 15.00m, false, "A Blade So Black", "1007" },
                    { 108, 8, "", "https://m.media-amazon.com/images/I/51BZdlchEsL.jpg", 14.99m, false, "A Dream So Dark", "1007" },
                    { 109, 8, "", "https://images-na.ssl-images-amazon.com/images/I/61GSqXVhhKL.jpg", 12.00m, false, "The Fire Next Time", "1007" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
