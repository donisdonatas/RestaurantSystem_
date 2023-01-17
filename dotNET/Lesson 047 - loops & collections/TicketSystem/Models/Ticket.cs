using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem.Models
{
    public class Ticket
    {
        public TicketType type { get; set; }
        public DateTime createDate { get; set; }
        public TicketStatus ticketStatus { get; set; }


        public Ticket(TicketType type)
        {
            this.type = type;
            createDate = DateTime.Now;
            ticketStatus = TicketStatus.AVAILABLE;
        }

        public void SetSold()       //nebutu geriau jo perkelti prie ticketing service?
        {
            ticketStatus = TicketStatus.SOLD;
        }

    }
}
