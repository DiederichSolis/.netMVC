using System;
using System.Collections.Generic;

namespace CINE.Models;

public partial class Movie
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string? Genre { get; set; }

    public int Duration { get; set; }

    public string? Rating { get; set; }

    public DateOnly? ReleaseDate { get; set; }

    public string? ImageUrl { get; set; }

    public virtual ICollection<Showtime> Showtimes { get; set; } = new List<Showtime>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
