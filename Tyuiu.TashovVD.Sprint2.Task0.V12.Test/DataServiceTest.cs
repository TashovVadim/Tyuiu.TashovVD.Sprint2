using Tyuiu.TashovVD.Sprint2.Task0.V12.Lib;

namespace Tyuiu.TashovVD.Sprint2.Task0.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            int x  = 1095;
            int y = 475;
            DataService ds = new DataService();
            var res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[] { true, false, true, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
