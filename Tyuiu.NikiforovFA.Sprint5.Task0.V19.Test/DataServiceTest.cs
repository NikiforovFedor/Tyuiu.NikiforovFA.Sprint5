using Tyuiu.NikiforovFA.Sprint5.Task0.V19.Lib;
namespace Tyuiu.NikiforovFA.Sprint5.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = @"C:\Users\Fedor\source\repos\Tyuiu.NikiforovFA.Sprint5\OutPutFileTask0.txt";
            FileInfo fin = new FileInfo(s);
            bool fex = fin.Exists;
            Assert.AreEqual(true, fex);
        }
    }
}