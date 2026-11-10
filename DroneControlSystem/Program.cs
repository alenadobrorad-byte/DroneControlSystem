using DroneControlSystem;

for (int i = 0; i < drones.Length; i++)
{
    drones[i].PrintInfo();

    if (drones[i].BatteryLevel < 20)
    {
        Console.WriteLine("Низкий заряд");
    }
    if (drones[i].BatteryLevel < 50)
    {
        Console.WriteLine("Заряд меньше 50%. Подзарядить? (да/нет)");
        string a = Console.ReadLine();

        if (a == "да")
        {
            drones[i].ChargeBattery(60);
        }
    }
}
Console.WriteLine("Проверка завершена.");

