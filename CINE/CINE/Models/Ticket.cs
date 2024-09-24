using System;
using System.Collections.Generic;

namespace CINE.Models;

public partial class Ticket
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int ShowtimeId { get; set; }

    public int MovieId { get; set; }

    public DateTime PurchaseTime { get; set; }

    public decimal TotalAmount { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Movie Movie { get; set; } = null!;

    public virtual Showtime Showtime { get; set; } = null!;

    public virtual ICollection<TicketSeat> TicketSeats { get; set; } = new List<TicketSeat>();
}
