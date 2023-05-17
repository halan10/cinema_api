using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            _ = modelBuilder.Entity<Session>().HasData(new[]
            {
                new Session() { Id = 1, Film_name = "Inception",Film_raiting = 8.8, Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the project and his team to disaster.",Price = 100.00, Next_session =  new DateTime(2023, 05, 15)},
                new Session() { Id = 2, Film_name = "Goodfellas",Film_raiting = 8.7, Description = "The story of Henry Hill and his life in the mafia, covering his relationship with his wife Karen and his mob partners Jimmy Conway and Tommy DeVito.",Price = 150, Next_session =  new DateTime(2023, 06, 17) },
                new Session() { Id = 3, Film_name = "City of God",Film_raiting = 8.6, Description = "In the slums of Rio, two kids' paths diverge as one struggles to become a photographer and the other a kingpin.",Price = 100, Next_session =  new DateTime(2023, 05, 25) },
                new Session() { Id = 4, Film_name = "The Dark Knight",Film_raiting = 9.0, Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",Price = 170, Next_session =  new DateTime(2023, 06, 10) },
                new Session() { Id = 5, Film_name = "Gladiator",Film_raiting = 8.5, Description = "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.",Price = 100, Next_session =  new DateTime(2023, 07, 21) }
            });

            modelBuilder.Entity<Actor>().HasData(new[]
            {
                new Actor() { Id = 1, Name = "Russell Crowe", Birthday = new DateTime(1964,04,07), Place_of_birth = "Wellington" },
                new Actor() { Id = 2, Name = "Matthew McConaughey", Birthday = new DateTime(1969,11,04), Place_of_birth = "Uvalde, Texas" },
                new Actor() { Id = 3, Name = "Alexandre Rodrigues", Birthday = new DateTime(1983,05,21), Place_of_birth = "Rio de Janeiro" },
                new Actor() { Id = 4, Name = "Christian Bale", Birthday = new DateTime(1974,01,30), Place_of_birth = "Haverfordwest" },
          
            });
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=VPD121_Shop_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //}

        // ------------- data collections (tables) -------------
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Session> Sessions { get; set; }
    }
}
