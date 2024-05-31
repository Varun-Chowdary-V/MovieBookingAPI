using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MovieBooking;

[Table("bookings")]
public partial class Booking
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("userid")]
    public long Userid { get; set; }

    [Column("movieid")]
    public int Movieid { get; set; }

    [Column("theatreid")]
    public int Theatreid { get; set; }

    [Column("booking_date")]
    public DateOnly BookingDate { get; set; }

    [Column("booking_time")]
    public TimeOnly BookingTime { get; set; }

    [Column("seatsString")]
    [StringLength(255)]
    [Unicode(false)]
    public string SeatsString { get; set; } = null!;

    [Column("price", TypeName = "decimal(10, 2)")]
    public decimal Price { get; set; }

    [ForeignKey("Movieid")]
    [InverseProperty("Bookings")]
    public virtual Movie Movie { get; set; } = null!;

    [ForeignKey("Theatreid")]
    [InverseProperty("Bookings")]
    public virtual Theatre Theatre { get; set; } = null!;

    [ForeignKey("Userid")]
    [InverseProperty("Bookings")]
    public virtual User User { get; set; } = null!;
}
