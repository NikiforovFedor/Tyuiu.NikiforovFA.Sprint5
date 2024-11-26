using Tyuiu.NikiforovFA.Sprint5.Task6.V18.Lib;
namespace Tyuiu.NikiforovFA.Sprint5.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFileValid()
        {
            string s = @"C:\DataSprint5\InPutDataFileTask6V18.txt";
            FileInfo fileInfo = new FileInfo(s);
            bool file = fileInfo.Exists;
            Assert.AreEqual(true, file);
        }
        [TestMethod]
        public void Calc()
        {
            DataService ds = new DataService(); 
            string s = @"C:\DataSprint5\InPutDataFileTask6V18.txt";
            Assert.AreEqual(ds.LoadFromDataFile(s), 2);
        }
    }
}