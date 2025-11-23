using Tyuiu.VitovskayaAN.Sprint5.Task3.V1.Lib;
using System.IO;
namespace Tyuiu.VitovskayaAN.Sprint5.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextDataValid()
        {
            string path = @"C:\Users\asus\AppData\Local\Temp\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}