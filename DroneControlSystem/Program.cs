using DroneControlSystem;
Console.WriteLine("*******************************************");
Console.WriteLine("*** Система управления БПЛА (версия 2.0) ***");
Console.WriteLine("*******************************************");
Console.Write("Введите команду (1 — взлёт, 2 — расчёт времени, 0 — выход): ");
string input = Console.ReadLine();
if (!int.TryParse(input, out int command))
{
    Console.WriteLine("Ошибка: введите число.");
}

Drone[] drones = new Drone[]
{
new Drone("DJI Mini 3", 85),
new Drone("Autel EVO Lite", 45),
new Drone("Parrot Anafi", 15),
new Drone("DJI Mini 4")
};
for (int i = 0; i < drones.Length; i++)
{
    drones[i].PrintInfo();
    if (drones[i].IsEngineOn)
    {
        int flightTime = drones[i].CalculateFlightTime();
        Console.WriteLine($"Время полета: {flightTime} мин.");
    }
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
Mission mission = new Mission("Разведка", drones[0], 100);
mission.Start();
