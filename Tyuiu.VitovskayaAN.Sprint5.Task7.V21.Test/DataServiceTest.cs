using Tyuiu.VitovskayaAN.Sprint5.Task7.V21.Lib;
namespace Tyuiu.VitovskayaAN.Sprint5.Task7.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V21.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            Assert.AreEqual(true, fileexists);
        }

        [TestMethod]
        public void CheckedExistsOutPutFile()
        {
            string path = @"C:\Users\asus\AppData\Local\Temp\OutPutDataFileTask7V21.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            Assert.AreEqual(true, fileexists);
        }
    }
}