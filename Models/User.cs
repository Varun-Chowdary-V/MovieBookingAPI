using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MovieBooking;

[Table("users")]
[Index("Email", Name = "UQ__users__A9D10534494D19E6", IsUnique = true)]
public partial class User
{
    [Key]
    public long Id { get; set; }

    [StringLength(255)]
    public string FirstName { get; set; } = null!;

    [StringLength(255)]
    public string LastName { get; set; } = null!;

    [StringLength(255)]
    public string Email { get; set; } = null!;

    [StringLength(255)]
    public string PasswordHashed { get; set; } = null!;

    [StringLength(50)]
    public string? Phone { get; set; }

    [Column("DOB")]
    public DateOnly? Dob { get; set; }

    [StringLength(50)]
    public string? Gender { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
