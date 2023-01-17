using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class ProgressBar
    {
        internal static int Progress = 0;
        
        public static async Task IncreaseProgress()
        {
            await Task.Run(() =>
            {
                while (Progress <= 100)
                {
                    Progress++;
                    Task.Delay(1000).Wait();
                }
            });
        }

        public static async Task PrintProgress()
        {
            await Task.Run(() =>
            {
                while (Progress <= 100)
                {
                    Console.WriteLine($"Progresas: {Progress}");
                    Task.Delay(3000).Wait();
                }
            });
        }
    }
}
