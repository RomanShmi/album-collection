using Microsoft.EntityFrameworkCore.Migrations;

namespace album_collection.Migrations
{
    public partial class newDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Image", "Title" },
                values: new object[] { "https://1071theboss.com/wp-content/uploads/2020/05/1091.jpg", "The Wall" });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Image", "Title" },
                values: new object[] { "https://www.udiscovermusic.com/wp-content/uploads/2017/04/The-Rolling-Stones-Debut-Album.jpg", "The Rolling Stones" });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Image", "Title" },
                values: new object[] { "https://i.pinimg.com/originals/8a/e8/8a/8ae88a537aefdbb5dc3347554601b330.jpg", "Oops!...I Did It Again" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Pink Floyd");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "The Rolling Stones");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Britney Spears");

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Image", "Name", "Origin" },
                values: new object[,]
                {
                    { 4, null, "Lady Gaga", null },
                    { 5, null, "Jay-Z", null }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "ReviewContent" },
                values: new object[] { "Jaxxon", "The Wall is not just classic stoner music but also great for those of us who are interested in music that challenges societal norms and has a great rhythm to each piece." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AlbumId", "Name", "ReviewContent" },
                values: new object[] { 2, "Eli", "4/5 :)" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AlbumId", "Name", "ReviewContent" },
                values: new object[] { 3, "Dawna", "FREE BRITNEY!!!!" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Another Brick In The Wall");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Goodbye Blue Sky");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "Route 66");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Little By Little");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "Oops!...I Did It Again");

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Title" },
                values: new object[] { 6, 3, "Lucky" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "Image", "Labe", "Title" },
                values: new object[] { 4, 4, "https://target.scene7.com/is/image/Target/GUEST_0c04bcc2-b529-4b14-9a43-5122f7c1b379?wid=325&hei=325&qlt=80&fmt=webp", null, "Born This Way" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "Image", "Labe", "Title" },
                values: new object[] { 5, 5, "https://images.complex.com/complex/images/c_fill,dpr_auto,f_auto,q_auto,w_1400/fl_lossy,pg_1/l1c9h415wrvx1bg3uacd/reasonable-doubt?fimg-client-default", null, "Reasonable Doubt" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AlbumId", "Name", "ReviewContent" },
                values: new object[] { 4, "Roman", "Gr8 Album" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AlbumId", "Name", "ReviewContent" },
                values: new object[] { 5, 5, "Jay", "Best rapper ever!!!! 10/10 Recommend" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Title" },
                values: new object[,]
                {
                    { 7, 4, "Born This Way" },
                    { 8, 4, "Judas" },
                    { 9, 5, "Can't Knock The Hustle" },
                    { 10, 5, "Feelin' It" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Image", "Title" },
                values: new object[] { null, "album1" });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Image", "Title" },
                values: new object[] { null, "album2" });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Image", "Title" },
                values: new object[] { null, "album3" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "artist1");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "artist2");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "artist3");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "ReviewContent" },
                values: new object[] { "name1", "review for albom 1" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AlbumId", "Name", "ReviewContent" },
                values: new object[] { 1, "name2", "review for albom 1" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AlbumId", "Name", "ReviewContent" },
                values: new object[] { 2, "name3", "review for albom 2" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AlbumId", "Name", "ReviewContent" },
                values: new object[] { 3, "name4", "review for albom 3" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "albom1song1");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "albom1song2");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "albom2song1");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "albom2song2");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "albom3song1");
        }
    }
}
