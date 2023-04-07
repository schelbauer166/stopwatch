
Menu();

static void Menu()
{
    Console.Clear();
    System.Console.WriteLine(@"
    S = Segundos -> 10s
    M = Minutos -> 1m
    0 = Sair
    Quanto tempo deseja contar?");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));
    int multiplier = 1;

    if (type == 'm')
    {
        multiplier = 60;
    }
    if (time == 0)
    {
        System.Environment.Exit(0);
    }
    PreStart(time * multiplier);

}

static void PreStart(int time)
{
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.WriteLine("Got...");
    Thread.Sleep(2500);

    Start(time);
}

// static void Start(int time)
// {
//     int currentTime = 0;

//     while (currentTime != time)
//     {
//         Console.Clear();
//         currentTime++;
//         Console.WriteLine(currentTime);
//         Thread.Sleep(1000);
//     }
//     Console.Clear();
//     Console.WriteLine("StopWatch finalizado!");
//     Thread.Sleep(2500);
// }

static void Start(int time)
{
    int currentTime = 0;

    for (currentTime = time; currentTime != 0; currentTime--)
    {
        Console.Clear();
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }
    Console.Clear();
    Console.WriteLine("StopWatch finalizado!");
    Thread.Sleep(2500);
}
