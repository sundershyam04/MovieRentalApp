using System;
using System.Data.Entity;
using System.Linq;

namespace MovieRentDB
{
    public class movierent : DbContext
    {

        public movierent()
            : base("name=movierent")
        {
            Database.SetInitializer<movierent>(new CreateDatabaseIfNotExists<movierent>());
        }



        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<User> Users { get; set; }




    }
}