using Tyuiu.NikiforovFA.Sprint5.Task0.V19.Lib;
namespace Tyuiu.NikiforovFA.Sprint5.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = @"C:\Users\Fedor\AppData\Local\Temp\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(s);
            bool file = fileInfo.Exists;
            Assert.AreEqual(true, file);
        }
    }
}