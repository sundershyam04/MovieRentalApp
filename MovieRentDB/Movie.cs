using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentDB
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        public string Title { get; set; }   

        public string Language { get; set; }

        public string Genre { get; set; }

        public int Rating { get; set; }

        public int Availability { get; set; }    

        public  virtual ICollection<User> Usrs { get; set; }

    }
}
