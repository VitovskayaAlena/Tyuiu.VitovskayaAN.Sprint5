using Tyuiu.VitovskayaAN.Sprint5.Task1.V4.Lib;
using System.IO;
namespace Tyuiu.VitovskayaAN.Sprint5.Task1.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\asus\source\repos\Tyuiu.VitovskayaAN.Sprint5\Tyuiu.VitovskayaAN.Sprint5.Task1.V4\bin\Debug\net8.0\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}

