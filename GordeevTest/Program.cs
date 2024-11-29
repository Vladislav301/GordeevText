using InspectorLib;
using System;

public class Example
{
    public static void Main(string[] args)
    {
        FunctionInsp inspection = new FunctionInsp("Городская автоинспекция", "Иванов Иван Иванович");

        Console.WriteLine($"Главный инспектор: {inspection.GetInspector()}");
        Console.WriteLine($"Название автоинспекции: {inspection.GetCarInspection()}");
        Console.WriteLine($"Сгенерированный госномер: {inspection.GenerateNumber('A')}");

        inspection.AddWorker("Петров Петр Петрович");
        Console.WriteLine($"Список сотрудников: {string.Join(", ", inspection.GetWorkers())}");

        bool inspectorChanged = inspection.SetInspector("Петров Петр Петрович");
        Console.WriteLine($"Инспектор изменен: {inspectorChanged}");
        Console.WriteLine($"Новый главный инспектор: {inspection.GetInspector()}");


        bool failedChange = inspection.SetInspector("Сидоров Сидор Сидорович"); 
        Console.WriteLine($"Инспектор изменен: {failedChange}");

    }
}


