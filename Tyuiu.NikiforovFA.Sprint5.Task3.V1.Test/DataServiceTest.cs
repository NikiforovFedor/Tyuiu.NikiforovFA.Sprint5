namespace Tyuiu.NikiforovFA.Sprint5.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextDataValid()
        {
            string s = @"C:\Users\Fedor\AppData\Local\Temp\OutPutFileTask3.txt";
            FileInfo fileInfo = new FileInfo(s);
            bool file = fileInfo.Exists;
            Assert.AreEqual(true, file);
        }
    }
}