using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repository.migrations
{
    /// <inheritdoc />
    public partial class add_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[,]
                {
                    { 1, 3, "Generic Concrete Pants", 93.745864516281427m, 81 },
                    { 2, 3, "Generic Soft Table", 84.5015003370064m, 69 },
                    { 3, 1, "Refined Metal Computer", 9.4216664909329084m, 33 },
                    { 4, 8, "Incredible Frozen Hat", 31.125724186177576m, 24 },
                    { 5, 3, "Small Frozen Gloves", 29.669678882940403m, 79 },
                    { 6, 2, "Incredible Soft Chips", 7.2806778613541809m, 72 },
                    { 7, 3, "Practical Wooden Sausages", 36.034087564910665m, 20 },
                    { 8, 5, "Rustic Plastic Ball", 87.651537526680643m, 75 },
                    { 9, 5, "Handcrafted Soft Bike", 2.7900770588821549m, 57 },
                    { 10, 4, "Incredible Wooden Chair", 34.868422772214085m, 66 },
                    { 11, 3, "Awesome Concrete Table", 37.089681604857694m, 12 },
                    { 12, 2, "Small Rubber Sausages", 63.134829886723858m, 58 },
                    { 13, 6, "Tasty Plastic Sausages", 86.387573789563771m, 86 },
                    { 14, 4, "Awesome Soft Soap", 98.321036561043724m, 20 },
                    { 15, 8, "Generic Plastic Pants", 64.15389404316685m, 36 },
                    { 16, 3, "Incredible Wooden Salad", 81.610069445610562m, 92 },
                    { 17, 6, "Rustic Steel Soap", 57.0999467767618m, 95 },
                    { 18, 3, "Ergonomic Fresh Ball", 32.49940317449266m, 69 },
                    { 19, 5, "Practical Rubber Salad", 8.4976081016052502m, 63 },
                    { 20, 6, "Incredible Concrete Pizza", 91.128894529990294m, 16 },
                    { 21, 1, "Rustic Granite Car", 81.453543864645358m, 84 },
                    { 22, 8, "Practical Plastic Towels", 18.062057744062309m, 58 },
                    { 23, 6, "Fantastic Soft Chair", 39.780917374909303m, 77 },
                    { 24, 5, "Sleek Concrete Pants", 5.0068998439961887m, 17 },
                    { 25, 6, "Intelligent Fresh Table", 18.04434137572969m, 89 },
                    { 26, 1, "Practical Granite Car", 73.798433220328255m, 94 },
                    { 27, 1, "Fantastic Plastic Gloves", 44.617025335298041m, 34 },
                    { 28, 4, "Tasty Steel Cheese", 7.2417719993065822m, 14 },
                    { 29, 2, "Practical Frozen Mouse", 87.848276236921045m, 8 },
                    { 30, 7, "Small Wooden Bacon", 95.169444920196679m, 81 },
                    { 31, 6, "Refined Frozen Pants", 89.867558293374421m, 5 },
                    { 32, 6, "Practical Metal Tuna", 65.492237537634412m, 71 },
                    { 33, 8, "Refined Concrete Soap", 43.87028055740056m, 85 },
                    { 34, 6, "Refined Wooden Gloves", 33.928189264610596m, 100 },
                    { 35, 4, "Generic Frozen Chicken", 62.319493568781811m, 0 },
                    { 36, 5, "Licensed Metal Mouse", 47.902246164446662m, 3 },
                    { 37, 2, "Rustic Cotton Pizza", 50.899655688956524m, 5 },
                    { 38, 3, "Handcrafted Plastic Tuna", 33.468991028031844m, 74 },
                    { 39, 3, "Awesome Rubber Chair", 43.357743370752238m, 39 },
                    { 40, 2, "Sleek Cotton Pizza", 61.978287894238891m, 67 },
                    { 41, 7, "Sleek Metal Bike", 8.5893350561943805m, 69 },
                    { 42, 3, "Fantastic Steel Sausages", 57.712615111704475m, 15 },
                    { 43, 8, "Awesome Soft Gloves", 56.904638918870368m, 21 },
                    { 44, 3, "Sleek Cotton Tuna", 98.826517668021472m, 25 },
                    { 45, 6, "Intelligent Rubber Pants", 79.976124619530886m, 10 },
                    { 46, 5, "Practical Metal Fish", 14.499583964732107m, 23 },
                    { 47, 8, "Tasty Rubber Chicken", 93.18403252405765m, 44 },
                    { 48, 2, "Incredible Wooden Bacon", 1.21991794609166173m, 12 },
                    { 49, 2, "Gorgeous Wooden Sausages", 36.557422978105567m, 99 },
                    { 50, 4, "Unbranded Steel Car", 12.668133018173698m, 14 },
                    { 51, 7, "Licensed Cotton Car", 63.261828430043374m, 48 },
                    { 52, 5, "Practical Steel Chicken", 34.033452473240164m, 5 },
                    { 53, 2, "Awesome Plastic Chicken", 8.6491299395561941m, 74 },
                    { 54, 1, "Intelligent Concrete Bike", 98.334000264519964m, 30 },
                    { 55, 4, "Fantastic Metal Hat", 94.460491012476115m, 16 },
                    { 56, 5, "Intelligent Frozen Bike", 68.738779627274404m, 57 },
                    { 57, 8, "Unbranded Metal Salad", 29.401686006759208m, 60 },
                    { 58, 7, "Gorgeous Metal Shirt", 66.622477522887406m, 67 },
                    { 59, 5, "Licensed Granite Tuna", 99.471424667433598m, 53 },
                    { 60, 3, "Incredible Granite Fish", 82.770346544010553m, 45 },
                    { 61, 2, "Rustic Cotton Computer", 49.838805684481285m, 89 },
                    { 62, 8, "Small Soft Pants", 9.8751552646436317m, 8 },
                    { 63, 8, "Intelligent Steel Mouse", 70.945822694162404m, 88 },
                    { 64, 2, "Handcrafted Plastic Pizza", 7.3683316321430905m, 99 },
                    { 65, 7, "Awesome Fresh Cheese", 23.137455341037817m, 84 },
                    { 66, 5, "Licensed Fresh Mouse", 50.325166721073232m, 89 },
                    { 67, 5, "Intelligent Frozen Car", 50.337573460436602m, 85 },
                    { 68, 2, "Sleek Metal Chicken", 87.826120349793418m, 36 },
                    { 69, 4, "Licensed Frozen Salad", 26.725957649035534m, 58 },
                    { 70, 5, "Awesome Wooden Tuna", 89.709505552999243m, 76 },
                    { 71, 7, "Unbranded Granite Pants", 31.268103366342952m, 12 },
                    { 72, 5, "Fantastic Concrete Chicken", 51.314142424576888m, 54 },
                    { 73, 5, "Rustic Cotton Cheese", 49.461366649031083m, 19 },
                    { 74, 4, "Licensed Soft Chips", 25.584123080022715m, 4 },
                    { 75, 2, "Generic Metal Pants", 68.179386828856753m, 65 },
                    { 76, 3, "Handmade Fresh Pizza", 51.705675088335784m, 98 },
                    { 77, 3, "Small Steel Keyboard", 96.22412591435722m, 13 },
                    { 78, 5, "Handmade Concrete Salad", 4.833540085511818m, 25 },
                    { 79, 3, "Small Fresh Sausages", 33.602891454679645m, 22 },
                    { 80, 6, "Tasty Rubber Car", 23.452640416561465m, 25 },
                    { 81, 4, "Gorgeous Rubber Cheese", 63.517997681240563m, 31 },
                    { 82, 6, "Generic Wooden Sausages", 29.001366292319695m, 93 },
                    { 83, 2, "Licensed Rubber Gloves", 2.7736663814732863m, 45 },
                    { 84, 1, "Handcrafted Fresh Towels", 1.34408392491627154m, 85 },
                    { 85, 2, "Generic Soft Gloves", 52.704623908666729m, 21 },
                    { 86, 2, "Handcrafted Steel Cheese", 73.526593828228705m, 99 },
                    { 87, 3, "Handcrafted Granite Salad", 24.77302135288795m, 6 },
                    { 88, 4, "Generic Fresh Ball", 84.281817130317091m, 63 },
                    { 89, 2, "Small Rubber Car", 27.10452600518158m, 73 },
                    { 90, 4, "Small Rubber Bike", 39.485646756180613m, 85 },
                    { 91, 2, "Licensed Steel Cheese", 82.071196227610435m, 46 },
                    { 92, 1, "Ergonomic Rubber Table", 29.728922499469027m, 88 },
                    { 93, 8, "Awesome Plastic Chair", 84.04858062421426m, 96 },
                    { 94, 6, "Tasty Wooden Gloves", 59.70951097731478m, 34 },
                    { 95, 3, "Generic Concrete Keyboard", 29.469358463052925m, 52 },
                    { 96, 7, "Handmade Soft Ball", 90.58719175750432m, 55 },
                    { 97, 1, "Gorgeous Rubber Table", 51.795613139337649m, 61 },
                    { 98, 5, "Ergonomic Rubber Gloves", 82.237695564092518m, 2 },
                    { 99, 8, "Incredible Granite Hat", 60.594259471050799m, 5 },
                    { 100, 3, "Refined Rubber Soap", 56.506641762912769m, 22 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
