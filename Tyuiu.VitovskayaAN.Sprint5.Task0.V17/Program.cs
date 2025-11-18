using Tyuiu.VitovskayaAN.Sprint5.Task0.V17.Lib;
class Program
{
    static void Main(string[] args)
    {
        int x = 3;

        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнила: Витовская А. Н. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнила: Витовская Алёна Николаевна | РППб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано выражение, вычислить его значение, результат сохранить в текстовый *");
        Console.WriteLine("* файл OutPutFileTask0.txt и вывести на консоль                           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("x = " + x);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(x);


        Console.WriteLine($"файл {res} создан!");

        Console.WriteLine(File.ReadAllText(res));

    }
}