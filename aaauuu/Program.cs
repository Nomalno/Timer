using System.Runtime.CompilerServices;
using System.Timers;

Console.Write("Time:");
void time(int hour, int minute,int second)
{
    int timeCountDown = hour * 3600 + minute * 60 + second;
    var timer = new System.Timers.Timer(1000);
    timer.Elapsed += (sender, eventArgs) =>
    {
        if (timeCountDown == 1)
        {
            timer.Dispose();
            Console.Clear();
            Console.WriteLine("Время вышло");
            return;
        }
        timeCountDown--;
        Console.Clear();
        Console.WriteLine($"Осталось {timeCountDown} секунды");
    };
    timer.Start();
    Console.ReadLine();
    Console.WriteLine("Повторить, изменить время или выйти?");
    var choose = Console.ReadLine();
    if (choose.Contains("Пов"))
    {
        time(0,0,4);
        Console.ReadKey();
    }
    if (choose.Contains("Изм")||choose.Contains("изм"))
    {
        Console.WriteLine("Часы,минуты,секунды:");
        hour = int.Parse(Console.ReadLine());
        minute = int.Parse(Console.ReadLine());
        second = int.Parse(Console.ReadLine());
        time(hour, minute, second);
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine("Выход...");
    }
    Console.ReadKey();
}
time(0,0,4);
