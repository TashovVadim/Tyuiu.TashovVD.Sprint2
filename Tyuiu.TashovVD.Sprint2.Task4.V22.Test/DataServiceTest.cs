using Tyuiu.TashovVD.Sprint2.Task4.V22.Lib;

namespace Tyuiu.TashovVD.Sprint2.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            double x, y;
            x = 4;
            y = 10;
            double wait = 135.5;
            DataService ds = new DataService();
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
