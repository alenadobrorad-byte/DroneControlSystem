using DroneControlSystem;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace DroneControlSystem
{
    internal class FileService
    {


        static void SaveDrones(Drone[] drones, string fileName)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(drones, options);
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine($"Состояние сохранено в файл {fileName}");
            static Drone[] LoadDrones(string fileName)
            {
                if (!File.Exists(fileName))
                {
                }
                Console.WriteLine("Файл не найден. Будет создан новый массив.");
                return new Drone[0];
                string jsonString = File.ReadAllText(fileName);
                Drone[]? drones = JsonSerializer.Deserialize<Drone[]>(jsonString);
                return drones ?? new Drone[0];
            }
        }
    }
}