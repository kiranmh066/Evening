using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookShowEntity
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Auto generate Column.
        public int Id { get; set; }

        public string Name { get; set; }

        public string MovieDesc { get; set; }

        public string MovieType { get; set; }
    }
}
