using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Shidai Man Wang", "Among the various realms, is the manliest and most handsome evil god in history! The peerless and handsome Xie Yan crosses over and falls into the vixen's lair. In order not to be drained of his entire life-force, he travels between various realms, cuts down a son of god, and repels an invading union hailing from across the ocean… This is the story of how he eventually becomes an evil god.", "IAEG40044004", 100.0, 90.0, 80.0, 85.0, "I'm An Evil God" },
                    { 2, "Wu Cheng'en", "Chinese comic novel, written by Wu Cheng’en, a novelist and poet of the Ming dynasty (1368–1644). The novel is based on the actual 7th-century pilgrimage of the Buddhist monk Xuanzang (602–664) to India in search of sacred texts. The story itself was already a part of Chinese folk and literary tradition in the form of colloquial stories, a poetic novelette, and a six-part drama when Wu Cheng’en formed it into his long and richly humorous novel.", "JTTW13681644", 140.0, 135.0, 125.0, 130.0, "Journey To The West" },
                    { 3, "Woniu Kuang Ben", "Thousands of worlds, the strong are like forests. A generation of fairy king Muyun, reborn into a bullied bastard, vowed to stir the situation and return to the top. Who will compete in the boundless universe? The heavens and the world, my lord ups and downs!", "SGE124374825", 150.0, 145.0, 140.0, 140.0, "Supreme God Emperor" },
                    { 4, "Mao Ni", "Fan Xian, born in the ancient empire of Southern Qing, inexplicably possesses memories from the 21st century. Wanting to learn about his mysterious past, he ventures to the capital, only to be entangled in the intrigues of the Emperor.", "JOL123459876", 135.0, 125.0, 115.0, 120.0, "Joy Of Life" },
                    { 5, "Mao Ni", "The epic and legendary tale of an extraordinary young man rising up from the masses, traversing his life in the pursuit of quantity over quality. His inquisitive voice echoes infinitely through the hills of the immortal Academy: “I am one who would rather suffer an eternity of destined calamities than beg for solace from the saints…”", "MNF032018323", 120.0, 110.0, 105.0, 108.0, "Nightfall" },
                    { 6, "Wo Chi Xi Hong Shi", "Year 2056, in a city in the Yuan Jiang Su Jin area. On top of a ruined, shattered six story residential apartment sits a teenager wearing a combat vest, militaristic trousers, and alloyed battle boots. On his back is a hexagonal shield and equipped is a blood-shadow battle knife. He sits there silently on the edge of the roof. At this time, the sparkling sky was shining and there was a refreshing breath within the air that blew towards him. However, there was only silence within the ruined, deserted city, with an occasional howl that makes your heart skip a beat.", "SWS051120160", 125.0, 122.0, 110.0, 117.0, "Swallowed Star" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
