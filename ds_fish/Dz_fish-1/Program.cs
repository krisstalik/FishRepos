using System;
using System.IO;

class FileExplorer
{
    static void Main(string[] args)
    {
        string currentPath = Directory.GetCurrentDirectory();

        while (true)
        {
            Console.WriteLine($"\nТекущий каталог: {currentPath}");
            ListFilesAndDirectories(currentPath);

            Console.Write("\nВведите команду (cd <папка>, exit): ");
            string command = Console.ReadLine().Trim();

            if (command.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
            else if (command.StartsWith("cd ", StringComparison.OrdinalIgnoreCase))
            {
                string newDir = command.Substring(3).Trim();
                if (newDir == "..")
                {
                    currentPath = Directory.GetParent(currentPath).FullName;
                }
                else
                {
                    string newPath = Path.Combine(currentPath, newDir);
                    if (Directory.Exists(newPath))
                    {
                        currentPath = newPath;
                    }
                    else
                    {
                        Console.WriteLine("Указанная папка не найдена.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Неизвестная команда.");
            }
        }
    }

    static void ListFilesAndDirectories(string path)
    {
        try
        {
            var items = Directory.GetFileSystemEntries(path);
            foreach (var item in items)
            {
                if (Directory.Exists(item))
                {
                    Console.WriteLine($"[DIR]  {Path.GetFileName(item)}");
                }
                else
                {
                    Console.WriteLine($"[FILE] {Path.GetFileName(item)}");
                }
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Доступ запрещён к этому каталогу.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Каталог не найден.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Произошла ошибка: {e.Message}");
        }
    }
}