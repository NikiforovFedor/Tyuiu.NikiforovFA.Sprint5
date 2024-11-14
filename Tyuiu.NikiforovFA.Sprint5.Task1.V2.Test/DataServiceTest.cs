namespace Tyuiu.NikiforovFA.Sprint5.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextDataValid()
        {
            string s = @"C:\Users\Fedor\source\repos\Tyuiu.NikiforovFA.Sprint5\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(s);
            bool file = fileInfo.Exists;
            Assert.AreEqual(true, file);
        }
    }
}