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
            Console.WriteLine("Ну кончился и что?");
            return;
        }
        timeCountDown--;
        Console.Clear();
        Console.WriteLine($"Осталось {timeCountDown} секунды");
    };
    timer.Start();
    Console.ReadLine();
    Console.WriteLine("Повторить или выйти?");
    var choose = Console.ReadLine();
    if (choose.Contains("Повт"))
    {
        Console.WriteLine("Часы,минуты,Секунды:");
        hour = int.Parse(Console.ReadLine());
        minute = int.Parse(Console.ReadLine());
        second = int.Parse(Console.ReadLine());
        time(hour, minute, second);
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine("Сам закрой");  
    }
    Console.ReadKey();
}
time(0,0,4);