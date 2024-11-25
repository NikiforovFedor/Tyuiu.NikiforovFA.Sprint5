namespace Tyuiu.NikiforovFA.Sprint5.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextDataValid()
        {
            string s = @"C:\Users\Fedor\AppData\Local\Temp\OutPutFileTask2.txt";
            FileInfo fileInfo = new FileInfo(s);
            bool file = fileInfo.Exists;
            Assert.AreEqual(true, file);
        }
    }
}