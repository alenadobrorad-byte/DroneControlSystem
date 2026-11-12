using System;
using System.IO;
using System.Collections.Generic;
using DroneControlSystem;

Drone[] drones = new Drone[]
{
new Drone("DJI Mini 3", 85),
new Drone("Autel EVO Lite", 45),
new Drone("Parrot Anafi", 15),
new Drone("DJI Mini 4")
};

while (true)
{
    Console.WriteLine("=== Система управления БПЛА (версия 3.0) ===");
    Console.WriteLine("1. Все дроны");
    Console.WriteLine("2. Взлёт");
    Console.WriteLine("3. Подзарядка");
    Console.WriteLine("4. Время полета");
    Console.WriteLine("0. Выход");


    if (!int.TryParse(Console.ReadLine(), out int c))
    {
        Console.WriteLine("Введите число.");
        continue;
    }

    if (c == 0)
        break;

    if (c == 1)
    {
        foreach (Drone d in drones)
            d.PrintInfo();
    }

    if (c >= 2 && c <= 4)
    {
        Console.WriteLine("Номер дрона (1-4):");

        if (!int.TryParse(Console.ReadLine(), out int n)
            || n < 1 || n > drones.Length)
        {
            Console.WriteLine("Неверный номер!");
            continue;
        }
        Drone d = drones[n - 1];

        if (c == 2) d.TakeOff();

        if (c == 3)
        {
            Console.WriteLine("Сколько зарядить?");
            if (int.TryParse(Console.ReadLine(), out int a) && a > 0)
            {
                d.ChargeBattery(a);
            }
            else
            {
                Console.WriteLine("Неверный заряд!");
            }
        }

        if (c == 4)
        {
            Console.WriteLine(d.CalculateFlightTime());
        }
    }

    if (c < 0 || c > 4)
    {
        Console.WriteLine("Нет такой команды!");
    }
}


