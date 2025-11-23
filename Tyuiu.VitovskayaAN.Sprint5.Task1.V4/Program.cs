using Tyuiu.VitovskayaAN.Sprint5.Task1.V4.Lib;
class Program
{
    static void Main(string[] args)
    {

        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнила: Витовская А. Н. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Класс File. Запись набора данных в текстовый файл                       *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнила: Витовская Алёна Николаевна | РППб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int a = -5;
        int b = 5;
        Console.WriteLine("StartValue = " + a);
        Console.WriteLine("StotValue = " + b);
        string res = ds.SaveToFileTextData(a, b);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Файл: " + res + " Создан!");
        Console.ReadKey();
    }
}
