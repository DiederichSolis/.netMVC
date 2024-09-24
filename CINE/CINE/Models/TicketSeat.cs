using System;
using System.Collections.Generic;

namespace CINE.Models;

public partial class TicketSeat
{
    public int Id { get; set; }

    public int TicketId { get; set; }

    public int SeatId { get; set; }

    public bool? IsSelected { get; set; }

    public virtual Seat Seat { get; set; } = null!;

    public virtual Ticket Ticket { get; set; } = null!;
}
