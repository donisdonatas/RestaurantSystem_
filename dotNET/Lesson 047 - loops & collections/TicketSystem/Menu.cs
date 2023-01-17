using TicketSystem.Models;

namespace TicketSystem
{

    public class Menu
    {

        //Methods
        public static ActionType GetActionType()
        {
            do
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("[1] Buy tickets");
                Console.WriteLine("[2] Create tickets");
                Console.WriteLine("[3] Preview report");
                Console.WriteLine("[4] Exit");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        return ActionType.BUY;
                    case "2":
                        return ActionType.CREATE;
                    case "3":
                        return ActionType.REPORT;
                    case "4":
                        return ActionType.EXIT;
                    default:
                        Console.WriteLine("\nIncorrect input!\n");
                        break;
                }
            } while (true);
           
        }

        public static TicketType GetTicketType()
        {
            do
            {
                Console.WriteLine("\nChoose ticket type:\n");
                Console.WriteLine("[1] 10 Eur.");
                Console.WriteLine("[2] 20 Eur.");
                Console.WriteLine("[3] 30 Eur.");

                string ticketTypeChoice = Console.ReadLine();

                switch (ticketTypeChoice)
                {
                    case "1":
                        return TicketType.T10;
                    case "2":
                        return TicketType.T20;
                    case "3":
                        return TicketType.T30;
                    default:
                        Console.WriteLine("\nIncorrect input!\n");
                        break;
                }
            } while (true);
        }

        public static int GetTicketQuantity()
        {
            int ticketQuantity = 0;
            do
            {
                Console.WriteLine("\nEnter quantity:\n");
                bool ticketQuantityInput = int.TryParse(Console.ReadLine(), out ticketQuantity);

                if (ticketQuantityInput && ticketQuantity > 0)
                {
                    return ticketQuantity;
                }
                else
                {
                    Console.WriteLine("Incorrect value!");
                }

            } while (true);
        }
    }
}
