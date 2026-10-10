using Tyuiu.TashovVD.Sprint2.Task5.V13.Lib;

namespace Tyuiu.TashovVD.Sprint2.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestFindDateOfNextDay()
        {
            int g, m, n;
            g = 2003; m = 12; n = 5;
            string wait = "2003/12/6";
            DataService ds = new DataService();
            var res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(wait, res);
        }
    }
}
