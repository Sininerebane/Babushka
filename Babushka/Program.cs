using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Babushka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int oldLadiesInQueue;
            int reseptionTimeMinutes = 10;
            int waitingHours;
            int minutesPerHour = 60;
            int waitingMinutes;
            int totalOldLadiesPerReseptionTime;

            Console.WriteLine("Вы заходите в поликлинику и видите огромную очередь из старушек");
            Console.Write("Введите количество старушек в очереди: ");
            oldLadiesInQueue = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Учитывайте, что фиксированное время приема одного человека всегда равно {reseptionTimeMinutes} минут. ");

            totalOldLadiesPerReseptionTime = oldLadiesInQueue * reseptionTimeMinutes;
            waitingHours = totalOldLadiesPerReseptionTime / minutesPerHour;
            waitingMinutes = totalOldLadiesPerReseptionTime % minutesPerHour;

            Console.WriteLine("Вам ждать своей очереди {0} часов, и {1} минут.", waitingHours, waitingMinutes);
            Console.ReadKey();
        }
    }
}
