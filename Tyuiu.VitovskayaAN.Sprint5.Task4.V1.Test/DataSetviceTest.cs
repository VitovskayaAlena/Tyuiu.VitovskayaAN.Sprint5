using Tyuiu.VitovskayaAN.Sprint5.Task4.V1.Lib;
namespace Tyuiu.VitovskayaAN.Sprint5.Task4.V1.Test
{
    [TestClass]
    public sealed class DataSetviceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V1.txt");
            FileInfo fileInfo = new FileInfo(path);
            double wait = -3.68;
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
