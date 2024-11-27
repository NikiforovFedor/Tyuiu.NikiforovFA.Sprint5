namespace Tyuiu.NikiforovFA.Sprint5.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadDataAndSaveValid()
        {
            string s = @"C:\DataSprint5\InPutDataFileTask7V29.txt";
            FileInfo fileInfo = new FileInfo(s);
            bool file = fileInfo.Exists;
            Assert.AreEqual(true, file);
        }
    }
}