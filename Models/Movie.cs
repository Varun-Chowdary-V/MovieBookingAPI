using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MovieBooking;

[Table("movies")]
public partial class Movie
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("title")]
    [StringLength(255)]
    [Unicode(false)]
    public string Title { get; set; } = null!;

    [Column("description", TypeName = "text")]
    public string Description { get; set; } = null!;

    [Column("lang")]
    [StringLength(50)]
    [Unicode(false)]
    public string Lang { get; set; } = null!;

    [Column("duration")]
    public int Duration { get; set; }

    [Column("poster")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Poster { get; set; }

    [Column("trailer")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Trailer { get; set; }

    [InverseProperty("Movie")]
    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
