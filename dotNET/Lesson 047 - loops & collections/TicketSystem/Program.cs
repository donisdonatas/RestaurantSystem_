// See https://aka.ms/new-console-template for more information
using TicketSystem;
using TicketSystem.Models;

TicketRepository repo = new TicketRepository();
TicketingService ticketingService = new TicketingService(repo);
ReportingService reportingService = new ReportingService(repo);

while (true)
{
    switch (Menu.GetActionType())
    {
        case ActionType.BUY:
            ticketingService.BuyTicket(Menu.GetTicketType(), Menu.GetTicketQuantity());
            break;
        case ActionType.CREATE:
            ticketingService.CreateTicket(Menu.GetTicketType(), Menu.GetTicketQuantity());
            break;
        case ActionType.REPORT:
            reportingService.ReportByStatus();
            break;
        case ActionType.EXIT:
            return;
    }
}
