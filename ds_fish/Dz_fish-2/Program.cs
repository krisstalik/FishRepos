using System;
using System.IO;

class DiskInfoApp
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Доступные диски:");
            ListDrives();

            Console.WriteLine("\nВведите 'exit' для выхода или нажмите любую клавишу для обновления информации.");
            string input = Console.ReadLine();
            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
        }
    }

    static void ListDrives()
    {
        DriveInfo[] drives = DriveInfo.GetDrives();

        foreach (DriveInfo drive in drives)
        {
            if (drive.IsReady) // Проверяем, готов ли диск
            {
                Console.WriteLine($"Диск: {drive.Name}");
                Console.WriteLine($"  Тип: {drive.DriveType}");
                Console.WriteLine($"  Файловая система: {drive.DriveFormat}");
                Console.WriteLine($"  Общий объем: {FormatBytes(drive.TotalSize)}");
                Console.WriteLine($"  Доступно: {FormatBytes(drive.AvailableFreeSpace)}");
                Console.WriteLine($"  Занято: {FormatBytes(drive.TotalSize - drive.AvailableFreeSpace)}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Диск: {drive.Name} (не готов)");
            }
        }
    }

    static string FormatBytes(long bytes)
    {
        string[] suffixes = { "Б", "КБ", "МБ", "ГБ", "ТБ" };
        int i;
        double doubleBytes = bytes;

        for (i = 0; i < suffixes.Length && bytes >= 1024; i++, bytes /= 1024)
        {
            doubleBytes = bytes / 1024.0;
        }

        return $"{doubleBytes:0.##} {suffixes[i]}";
    }
}
