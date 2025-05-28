using System;
using System.IO;

class SimpleFileExplorer
{
    static void Main(string[] args)
    {
        string currentDirectory = Directory.GetCurrentDirectory();

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Текущий каталог: {currentDirectory}");
            Console.WriteLine("Содержимое:");

            // Получаем и отображаем файлы и папки
            DisplayContents(currentDirectory);

            Console.WriteLine("\nКоманды:");
            Console.WriteLine("1. Перейти в каталог");
            Console.WriteLine("2. Создать файл");
            Console.WriteLine("3. Вернуться в родительский каталог");
            Console.WriteLine("4. Выйти");
            Console.Write("Введите номер команды: ");

            string command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    currentDirectory = ChangeDirectory(currentDirectory);
                    break;
                case "2":
                    CreateFile(currentDirectory);
                    break;
                case "3":
                    currentDirectory = Directory.GetParent(currentDirectory)?.FullName ?? currentDirectory;
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Неверная команда. Нажмите любую клавишу для продолжения.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void DisplayContents(string directory)
    {
        try
        {
            var directories = Directory.GetDirectories(directory);
            var files = Directory.GetFiles(directory);

            foreach (var dir in directories)
            {
                Console.WriteLine($"[DIR] {Path.GetFileName(dir)}");
            }

            foreach (var file in files)
            {
                Console.WriteLine($"[FILE] {Path.GetFileName(file)}");
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Нет доступа к этому каталогу.");
        }
    }

    static string ChangeDirectory(string currentDirectory)
    {
        Console.Write("Введите имя каталога для перехода: ");
        string dirName = Console.ReadLine();
        string newPath = Path.Combine(currentDirectory, dirName);

        if (Directory.Exists(newPath))
        {
            return newPath;
        }
        else
        {
            Console.WriteLine("Каталог не найден. Нажмите любую клавишу для продолжения.");
            Console.ReadKey();
            return currentDirectory;
        }
    }

    static void CreateFile(string directory)
    {
        Console.Write("Введите имя файла для создания: ");
        string fileName = Console.ReadLine();
        string filePath = Path.Combine(directory, fileName);

        try
        {
            using (File.Create(filePath)) { }
            Console.WriteLine($"Файл '{fileName}' успешно создан.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при создании файла: {ex.Message}");
        }

        Console.WriteLine("Нажмите любую клавишу для продолжения.");
        Console.ReadKey();
    }
}
