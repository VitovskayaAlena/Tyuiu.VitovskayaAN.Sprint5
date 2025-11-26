using Tyuiu.VitovskayaAN.Sprint5.Task6.V27.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнила: Витовская А. Н. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Обработка текстовых файлов                                              *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #27                                                             *");
        Console.WriteLine("* Выполнила: Витовская Алёна Николаевна | РППб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Найти количество трехзначных чисел в заданной строке.                   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");
        string path = @"C:\DataSprint5\InPutDataFileTask6V27.txt";

        if (!File.Exists(path))
        {
            Console.WriteLine($"Файл {path} не найден!");
            Console.WriteLine("Создайте папку C:\\DataSprint5\\ и скопируйте в нее файл InPutDataFileTask6V27.txt");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Данные находятся в файле: " + path);

        string fileContent = File.ReadAllText(path);
        Console.WriteLine("Содержимое файла: " + fileContent);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.LoadFromDataFile(path);
        Console.WriteLine("Количество трехзначных чисел в строке = " + res);
        Console.ReadKey();
    }
}