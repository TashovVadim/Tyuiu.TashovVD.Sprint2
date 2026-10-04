using Tyuiu.TashovVD.Sprint2.Task1.V23.Lib;

namespace Tyuiu.TashovVD.Sprint2.Task1.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            int a, b, c, d;
            a = 12; b = 13; c = 14; d = 15;

            DataService ds = new DataService();
            var res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[] { false, false, true, false, true, true };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
