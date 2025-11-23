using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VitovskayaAN.Sprint5.Task0.V17.Lib
{
    public class DataService : ISprint5Task0V17
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();

            double res = 2.4 * Math.Pow(x, 3) + 0.4 * Math.Pow(x, 2) - 1.4 * x + 4.1;

            res = Math.Round(res, 3);

            File.WriteAllText(path, res.ToString());

            return path;
        }
    }
}

