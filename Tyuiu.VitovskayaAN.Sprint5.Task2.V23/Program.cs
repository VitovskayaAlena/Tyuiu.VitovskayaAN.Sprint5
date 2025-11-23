using Tyuiu.VitovskayaAN.Sprint5.Task2.V23.Lib;
class Program
{
    static void Main(string[] args)
    {
        int[,] mtrx = new int[3, 3] { { 7, 2, 8 },
                                      { 6, 9, 1 },
                                      { 2, 3, 5 } };

        int rows = mtrx.GetUpperBound(0) + 1;
        int cols = mtrx.Length / rows;

        DataService ds = new DataService();
    Console.Title = "Спринт #5 | Выполнила: Витовская А. Н. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #5                                                               *");
    Console.WriteLine("* Класс File. Запись набора данных в текстовый файл                       *");
    Console.WriteLine("* Задание #2                                                              *");
    Console.WriteLine("* Вариант #23                                                             *");
    Console.WriteLine("* Выполнила: Витовская Алёна Николаевна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("\nМассив: ");

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(mtrx[i, j] + "\t");
        }

        Console.WriteLine();
    }
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
    Console.WriteLine("***************************************************************************");
    string res = ds.SaveToFileTextData(mtrx);

    Console.WriteLine("Файл: " + res);
    Console.WriteLine("Создан.");
    Console.ReadKey();
    }
}