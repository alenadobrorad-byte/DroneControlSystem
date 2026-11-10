using DroneControlSystem;
Console.WriteLine("=== Система управления БПЛА (версия 1.0) ===\n");
// Создание объекта дрона с помощью конструктора
Drone[] drones = new Drone[]
{
new Drone("DJI Mini 3", 85),
new Drone("Autel EVO Lite", 45),
new Drone("Parrot Anafi", 15)
};
// Вывод информации
foreach (Drone drone in drones)
{
    drone.PrintInfo();

    if (drone.BatteryLevel < 20)
    {
        Console.WriteLine("Низкий заряд");
    }
}
Console.WriteLine("Проверка дронов завершена");
