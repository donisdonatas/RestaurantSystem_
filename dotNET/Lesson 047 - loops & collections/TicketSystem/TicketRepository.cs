using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.Models;

namespace TicketSystem
{
    public class TicketRepository
    {
        List<Ticket> ticketList = new List<Ticket>();

        public void AddTicket(Ticket ticket)
        {
            ticketList.Add(ticket);
        }

        public List<Ticket> GetAvailableTicketsOfType(TicketType ticketType) 
        {
            return ticketList.FindAll(ticket => ticket.type == ticketType && ticket.ticketStatus == TicketStatus.AVAILABLE);
        }

        public List<Ticket> GetTicketsByStatus(TicketStatus status)
        {
            return ticketList.FindAll(ticket => ticket.ticketStatus == status);
        }

    }
}
