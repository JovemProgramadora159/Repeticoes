int bateria = 3;

// while (bateria > 0)
// {
//     Console.WriteLine("Tocando música...");
//     bateria--; // -- diminui 1
//     Thread.Sleep(1000); // await Task.Delay(1000);
// }
while (true)
{
    Console.WriteLine("Tocando música...");
    bateria--;
    Thread.Sleep(1000);
    if (bateria <= 0)
    {
        break;
    }
}

// senac47278.local