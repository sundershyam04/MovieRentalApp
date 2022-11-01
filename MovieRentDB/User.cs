using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentDB
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public int UserName { get; set; }

        public int Category { get; set; }

        public virtual ICollection<Movie> Movs { get; set; }

    }
}
