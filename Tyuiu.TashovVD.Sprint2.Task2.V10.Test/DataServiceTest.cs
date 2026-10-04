using Tyuiu.TashovVD.Sprint2.Task2.V10.Lib;

namespace Tyuiu.TashovVD.Sprint2.Task2.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            int x, y;
            x = 10;
            y = 8;

            DataService ds = new DataService();
            bool wait = true;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
