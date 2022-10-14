using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookShowEntity
{
    public class BookTicket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Auto generate Column.
        public int Id { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("ShowTiming")]
        public int ShowId { get; set; }
        public ShowTiming ShowTRiming { get; set; }
    }
}
