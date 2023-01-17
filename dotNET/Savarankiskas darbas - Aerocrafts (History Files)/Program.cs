using Aeroplanes.Repositories;
using Aeroplanes.Models;
using Aeroplanes.Servises;
using System;
using Aeroplanes.Reports;

namespace Aeroplanes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Labas, čia dispečerinė");
            Console.WriteLine("----------------------");

            DefaultValues.AddDefaultValuesToAllRepositories();

            Console.WriteLine("----------------------");

            HTMLGenerator Html = new HTMLGenerator();
            string htmlText = Html.GenerateHTMLWithColor();

            Console.WriteLine("----------------------");

            EmailService sendEmail = new EmailService();
            sendEmail.SendEmail(htmlText);

            Console.ReadLine();
        }
    }
}
