using System.Threading.Tasks;

namespace ConsoleApp1;
class Program
{
    static async Task Main()
    {
        Console.WriteLine("Hello, World!");


        Task task1 = ProgressBar.IncreaseProgress();
        Task task2 = ProgressBar.PrintProgress();
        Task.WaitAll(task1, task2);
    }
}
