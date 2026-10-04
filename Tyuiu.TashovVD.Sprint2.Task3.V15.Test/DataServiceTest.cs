using Tyuiu.TashovVD.Sprint2.Task3.V15.Lib;

namespace Tyuiu.TashovVD.Sprint2.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCondition1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(2);
            double wait = 11;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestCondition2()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(0);
            double wait = 0.75;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestCondition3()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(1);
            double wait = 256;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestCondition4()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(-20);
            double wait = -219.95;
            Assert.AreEqual(wait, res);
        }
    }
}
