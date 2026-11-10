using DroneControlSystem;
Console.WriteLine("=== Система управления БПЛА (версия 1.0) ===\n");
Drone[] drones = new Drone[]
{
new Drone("DJI Mini 3", 85),
new Drone("Autel EVO Lite", 45),
new Drone("Parrot Anafi", 15)
};
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

