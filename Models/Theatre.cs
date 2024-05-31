using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MovieBooking;

[Table("theatres")]
public partial class Theatre
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("theatreName")]
    [StringLength(255)]
    [Unicode(false)]
    public string TheatreName { get; set; } = null!;

    [Column("showTimings")]
    [StringLength(255)]
    [Unicode(false)]
    public string ShowTimings { get; set; } = null!;

    [Column("location")]
    [StringLength(255)]
    [Unicode(false)]
    public string Location { get; set; } = null!;

    [Column("convFee", TypeName = "decimal(10, 2)")]
    public decimal ConvFee { get; set; }

    [Column("ticketFare", TypeName = "decimal(10, 2)")]
    public decimal TicketFare { get; set; }

    [Column("bookedSeats")]
    [StringLength(255)]
    [Unicode(false)]
    public string? BookedSeats { get; set; }

    [InverseProperty("Theatre")]
    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
