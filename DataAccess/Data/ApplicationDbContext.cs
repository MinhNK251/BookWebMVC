using Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
		public DbSet<OrderHeader> OrderHeaders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }
		public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { 
                    Id = 1, 
                    Title = "I'm An Evil God", 
                    Author = "Shidai Man Wang", 
                    Description = "Among the various realms, is the manliest and most handsome evil god in history! The peerless and handsome Xie Yan crosses over and falls into the vixen's lair. In order not to be drained of his entire life-force, he travels between various realms, cuts down a son of god, and repels an invading union hailing from across the ocean… This is the story of how he eventually becomes an evil god.", 
                    ISBN = "IAEG40044004", 
                    ListPrice = 100, 
                    Price = 90, 
                    Price50 = 85, 
                    Price100 = 80,
                    CategoryId = 1,
					ImageUrl = "https://s1.fastscans.net/ta-la-ta-de/thumbnail/ea28d2b23f1b61a33f369bc80528e2d8.jpg"
				},
                new Product
                {
                    Id = 2,
                    Title = "Journey To The West",
                    Author = "Wu Cheng'en",
                    Description = "Chinese comic novel, written by Wu Cheng’en, a novelist and poet of the Ming dynasty (1368–1644). The novel is based on the actual 7th-century pilgrimage of the Buddhist monk Xuanzang (602–664) to India in search of sacred texts. The story itself was already a part of Chinese folk and literary tradition in the form of colloquial stories, a poetic novelette, and a six-part drama when Wu Cheng’en formed it into his long and richly humorous novel.",
                    ISBN = "JTTW13681644",
                    ListPrice = 140,
                    Price = 135,
                    Price50 = 130,
                    Price100 = 125,
                    CategoryId = 3,
					ImageUrl = "https://m.media-amazon.com/images/I/71RZ0GED4jL._AC_UF1000,1000_QL80_.jpg"
				},
                new Product
                {
                    Id = 3,
                    Title = "Supreme God Emperor",
                    Author = "Woniu Kuang Ben",
                    Description = "Thousands of worlds, the strong are like forests. A generation of fairy king Muyun, reborn into a bullied bastard, vowed to stir the situation and return to the top. Who will compete in the boundless universe? The heavens and the world, my lord ups and downs!",
                    ISBN = "SGE124374825",
                    ListPrice = 150,
                    Price = 145,
                    Price50 = 140,
                    Price100 = 140,
					CategoryId = 1,
					ImageUrl = "https://cdn.novelupdates.com/images/2024/04/Supreme-God-Emperor.jpg"
				},
                new Product
                {
                    Id = 4,
                    Title = "Joy Of Life",
                    Author = "Mao Ni",
                    Description = "Fan Xian, born in the ancient empire of Southern Qing, inexplicably possesses memories from the 21st century. Wanting to learn about his mysterious past, he ventures to the capital, only to be entangled in the intrigues of the Emperor.",
                    ISBN = "JOL123459876",
                    ListPrice = 135,
                    Price = 125,
                    Price50 = 120,
                    Price100 = 115,
					CategoryId = 3,
					ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1589618339i/52618862.jpg"
				},
                new Product
                {
                    Id = 5,
                    Title = "Nightfall",
                    Author = "Mao Ni",
                    Description = "The epic and legendary tale of an extraordinary young man rising up from the masses, traversing his life in the pursuit of quantity over quality. His inquisitive voice echoes infinitely through the hills of the immortal Academy: “I am one who would rather suffer an eternity of destined calamities than beg for solace from the saints…”",
                    ISBN = "MNF032018323",
                    ListPrice = 120,
                    Price = 110,
                    Price50 = 108,
                    Price100 = 105,
					CategoryId = 3,
					ImageUrl = "https://i0.wp.com/thaophuonghoang.wordpress.com/wp-content/uploads/2020/06/jiangye.jpg?w=463&h=&ssl=1"
				},
                new Product
                {
                    Id = 6,
                    Title = "Swallowed Star",
                    Author = "Wo Chi Xi Hong Shi",
                    Description = "Year 2056, in a city in the Yuan Jiang Su Jin area. On top of a ruined, shattered six story residential apartment sits a teenager wearing a combat vest, militaristic trousers, and alloyed battle boots. On his back is a hexagonal shield and equipped is a blood-shadow battle knife. He sits there silently on the edge of the roof. At this time, the sparkling sky was shining and there was a refreshing breath within the air that blew towards him. However, there was only silence within the ruined, deserted city, with an occasional howl that makes your heart skip a beat.",
                    ISBN = "SWS051120160",
                    ListPrice = 125,
                    Price = 122,
                    Price50 = 117,
                    Price100 = 110,
					CategoryId = 2,
					ImageUrl = "https://cdn.novelupdates.com/images/2017/06/Swallowed-Star.jpg"
                }
                );

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Light Novel",
                    StreetAddress = "123 Tech St",
                    City = "Tech City",
                    PostalCode = "12121",
                    State = "IL",
                    PhoneNumber = "6669990000"
                },
                new Company
                {
                    Id = 2,
                    Name = "Vivid Books",
                    StreetAddress = "999 Vid St",
                    City = "Vid City",
                    PostalCode = "66666",
                    State = "IL",
                    PhoneNumber = "7779990000"
                },
                new Company
                {
                    Id = 3,
                    Name = "Readers Club",
                    StreetAddress = "999 Main St",
                    City = "Lala land",
                    PostalCode = "99999",
                    State = "NY",
                    PhoneNumber = "1113335555"
                }
                );
        }
    }
}
