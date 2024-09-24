using System;
using System.Collections.Generic;

namespace CINE.Models;

public partial class Seat
{
    public int Id { get; set; }

    public int RoomId { get; set; }

    public string SeatNumber { get; set; } = null!;

    public bool? IsAvailable { get; set; }

    public decimal Price { get; set; }

    public virtual Room Room { get; set; } = null!;

    public virtual ICollection<TicketSeat> TicketSeats { get; set; } = new List<TicketSeat>();
}
